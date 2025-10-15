using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using Simulador.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Simulador.Models.Enums;

namespace Simulador.Services
{
    public static class SimuladorService
    {
        public static void Simular(RandomConfig config)
        {
            Process currentProcess = Process.GetCurrentProcess();

            config.MaxBytes = currentProcess.PrivateMemorySize64;
            long memoryBefore = currentProcess.PrivateMemorySize64;

            var stopwatch = Stopwatch.StartNew();

            var numbers = RandomNumberService.Random(config);

            stopwatch.Stop();

            string tempoExecucao;
            if (stopwatch.Elapsed.TotalSeconds < 1)
                tempoExecucao = $"{stopwatch.ElapsedMilliseconds} ms";
            else if (stopwatch.Elapsed.TotalMinutes < 1)
                tempoExecucao = $"{stopwatch.Elapsed.TotalSeconds:F2} segundos";
            else
                tempoExecucao = $"{stopwatch.Elapsed.Minutes}m {stopwatch.Elapsed.Seconds}s";

            try
            {
                CreateFile(numbers, config.FolderPath);

                CreateReport(numbers, config, (config.MaxBytes - memoryBefore), tempoExecucao);
            } 
            catch(Exception e)
            {
                throw e;
            }

            long memoryAfter = currentProcess.PrivateMemorySize64;
        }

        private static void CreateFile(List<long> numeros, string folderPath)
        {
            string fileName = $"NUMEROS_SORTEADOS_{DateTime.Now:yyyyMMdd_HHmmss}.txt";
            string filePath = Path.Combine(folderPath, fileName);

            try
            {
                string numerosConcatenados = string.Join(",", numeros.Select(n => n.ToString()));

                File.WriteAllText(filePath, numerosConcatenados);

                Console.WriteLine($"Arquivo criado com sucesso em: {filePath}");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private static void CreateReport(List<long> numeros, RandomConfig config, long usedBytes, string tempoExecucao)
        {
            GlobalFontSettings.FontResolver = new MyFontResolver();

            if (numeros == null || numeros.Count == 0)
                throw new ArgumentException("A lista de números não pode estar vazia.");

            if (!Directory.Exists(config.FolderPath))
                Directory.CreateDirectory(config.FolderPath);

            int numBins = 10;
            long intervalo = (long)Math.Ceiling((config.Maximo - config.Minimo + 1) / (double)numBins);

            var labels = new List<string>();
            var counts = new List<int>();

            for (int i = 0; i < numBins; i++)
            {
                long start = config.Minimo + (i * intervalo);
                long end = Math.Min(start + intervalo - 1, config.Maximo);

                labels.Add($"{start} - {end}");
                counts.Add(numeros.Count(n => n >= start && n <= end));

                if (end >= config.Maximo) break;
            }
            var plt = new ScottPlot.Plot();
            double[] valores = counts.Select(v => (double)v).ToArray();
            double[] posicoes = Enumerable.Range(0, valores.Length).Select(i => (double)i).ToArray();

            var barras = plt.Add.Bars(valores);

            for (int i = 0; i < valores.Length; i++)
            {
                var texto = plt.Add.Text(valores[i].ToString(), posicoes[i], valores[i]);
                texto.LabelFontSize = 12;
                texto.LabelFontColor = ScottPlot.Colors.Black;
                texto.LabelAlignment = ScottPlot.Alignment.LowerCenter;
                texto.OffsetY = -5;
            }

            plt.Axes.Bottom.SetTicks(posicoes, labels.ToArray());
            plt.Title("Distribuição de Números");
            plt.YLabel("Quantidade");
            plt.XLabel("Intervalos");
            plt.Axes.AutoScale();
            plt.Axes.Margins(top: 0.15);

            string chartPath = Path.Combine(config.FolderPath, "grafico_temp.png");
            plt.SavePng(chartPath, 800, 400);

            string pdfPath = Path.Combine(config.FolderPath, $"Distribuicao_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
            using (PdfDocument document = new PdfDocument())
            {
                document.Info.Title = "RELATÓRIO";
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont fontTitulo = new XFont("Arial", 18);
                gfx.DrawString("RELATÓRIO", fontTitulo, XBrushes.Black,
                    new XRect(0, 30, page.Width, 50), XStringFormats.TopCenter);

                XImage image = XImage.FromFile(chartPath);
                double imageWidth = image.PixelWidth * 72 / image.HorizontalResolution;
                double imageHeight = image.PixelHeight * 72 / image.VerticalResolution;
                double x = (page.Width - imageWidth) / 2;
                double yGrafico = 100;
                gfx.DrawImage(image, x, yGrafico, imageWidth, imageHeight);

                double yInicial = yGrafico + imageHeight + 30;
                double margemEsquerda = 60;
                double margemDireita = page.Width - 60;

                XFont fontSubtitulo = new XFont("Arial", 14, XFontStyleEx.Bold);
                XFont fontTexto = new XFont("Arial", 11);
                XFont fontDestaque = new XFont("Arial", 11, XFontStyleEx.Bold);

                XPen caneta = new XPen(XColors.Gray, 1);
                gfx.DrawLine(caneta, margemEsquerda, yInicial - 10, margemDireita, yInicial - 10);

                gfx.DrawString("Estatísticas", fontSubtitulo, XBrushes.DarkBlue,
                    new XRect(margemEsquerda, yInicial, margemDireita - margemEsquerda, 20),
                    XStringFormats.TopLeft);

                yInicial += 25;

                int totalNumeros = numeros.Count;
                double media = numeros.Average();
                long mediana = numeros.OrderBy(n => n).ElementAt(totalNumeros / 2);

                string[] informacoes = new string[]
                {
                    $"Total de números analisados: {totalNumeros:N0}",
                    $"Intervalo: {config.Minimo} a {config.Maximo}",
                    $"Média: {media:N2}",
                    $"Mediana: {mediana}",
                    $"Número de intervalos: {counts.Count}",
                    $"Data de geração: {DateTime.Now:dd/MM/yyyy HH:mm:ss}",
                    $"Memória usada: {usedBytes} bytes",
                    $"Tempo de processamento: {tempoExecucao}"
                };

                double espacamentoLinha = 18;
                foreach (string info in informacoes)
                {
                    gfx.DrawEllipse(XBrushes.DarkBlue, margemEsquerda, yInicial + 4, 4, 4);

                    gfx.DrawString(info, fontTexto, XBrushes.Black,
                        new XRect(margemEsquerda + 15, yInicial, margemDireita - margemEsquerda - 15, 20),
                        XStringFormats.TopLeft);

                    yInicial += espacamentoLinha;
                }

                yInicial += 10;

                gfx.DrawString("Parâmetros", fontSubtitulo, XBrushes.DarkBlue,
                   new XRect(margemEsquerda, yInicial, margemDireita - margemEsquerda, 20),
                   XStringFormats.TopLeft);

                yInicial += 25;

                string geradorName = "";

                if (config.Gerador == EGeradores.LINEAR_CONGRUENTIAL_GENERATOR)
                {
                    geradorName = "Linear Congruential Generator (LCG)";

                    informacoes = new string[]
                    {
                        $"Gerador usado: {geradorName}",
                        $"Semente inicial: {config.SementeInicial}",
                        $"Multiplicador: {config.Multiplicador}",
                        $"Incremento: {config.Incremento}",
                        $"Módulo: {config.Modulo}"
                    };
                }
                else if (config.Gerador == EGeradores.MERSENNE_TWISTER)
                {
                    geradorName = "Mersenne Twister";

                    informacoes = new string[]
                    {
                        $"Gerador usado: {geradorName}",
                        $"Semente inicial: {config.SementeInicial}"
                    };
                }
                else
                {
                    geradorName = "Random Number Generator (TRNG)";

                    informacoes = new string[]
                    {
                        $"Gerador usado: {geradorName}"
                    };
                }

                espacamentoLinha = 18;
                foreach (string info in informacoes)
                {
                    gfx.DrawEllipse(XBrushes.DarkBlue, margemEsquerda, yInicial + 4, 4, 4);

                    gfx.DrawString(info, fontTexto, XBrushes.Black,
                        new XRect(margemEsquerda + 15, yInicial, margemDireita - margemEsquerda - 15, 20),
                        XStringFormats.TopLeft);

                    yInicial += espacamentoLinha;
                }

                yInicial += 15;
                XBrush fundoDestaque = new XSolidBrush(XColor.FromArgb(240, 240, 255));
                gfx.DrawRectangle(fundoDestaque, margemEsquerda - 10, yInicial - 5,
                    margemDireita - margemEsquerda + 20, 50);

                gfx.DrawString("Observações:", fontDestaque, XBrushes.DarkBlue,
                    new XRect(margemEsquerda, yInicial, margemDireita - margemEsquerda, 20),
                    XStringFormats.TopLeft);

                yInicial += 20;
                string observacao = "Este relatório apresenta a distribuição dos números em 10 intervalos equidistantes.";
                gfx.DrawString(observacao, fontTexto, XBrushes.Black,
                    new XRect(margemEsquerda, yInicial, margemDireita - margemEsquerda, 40),
                    XStringFormats.TopLeft);

                document.Save(pdfPath);
            }

            File.Delete(chartPath);
        }
    }
}
