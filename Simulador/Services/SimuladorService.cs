using PdfSharp.Drawing;
using PdfSharp.Fonts;
using PdfSharp.Pdf;
using PdfSharp.Fonts;
using PdfSharp.Snippets.Font;
using Simulador.Models;
using Simulador.Util;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Simulador.Services
{
    public static class SimuladorService
    {
        public static void Simular(RandomConfig config)
        {
            Process currentProcess = Process.GetCurrentProcess();

            config.MaxBytes = currentProcess.PrivateMemorySize64;
            long memoryBefore = currentProcess.PrivateMemorySize64;

            Console.WriteLine("MEMÓRIA ANTES: " + currentProcess.PrivateMemorySize64);

            var numbers = RandomNumberService.Random(config);

            try
            {
                CreateFile(numbers, config.FolderPath);

                CreateReport(numbers,config.Minimo, config.Maximo, config.FolderPath);
            } 
            catch(Exception e)
            {
                MessageHelper.ErrorMessageBox("ERRO AO GERAR ARQUIVOS! " + e.Message, "ERRO");
            }

            long memoryAfter = currentProcess.PrivateMemorySize64;

            Console.WriteLine($"Memória usada: {config.MaxBytes - memoryBefore} bytes");
        }

        private static void CreateFile(List<long> numeros, string folderPath)
        {
            string filePath = Path.Combine(folderPath, "NUMEROS_SORTEADOS.txt");

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

        private static void CreateReport(List<long> numeros, long min, long max, string folderPath)
        {
            GlobalFontSettings.FontResolver = new MyFontResolver();

            if (numeros == null || numeros.Count == 0)
                throw new ArgumentException("A lista de números não pode estar vazia.");

            if (!Directory.Exists(folderPath))
                Directory.CreateDirectory(folderPath);

            int numBins = 10;
            long intervalo = Math.Max(1, (max - min) / numBins);

            var labels = new List<string>();
            var counts = new List<int>();

            for (long start = min; start <= max; start += intervalo)
            {
                long end = Math.Min(start + intervalo - 1, max);
                labels.Add($"{start} - {end}");
                counts.Add(numeros.Count(n => n >= start && n <= end));

                if (end == max) break;
            }

            var plt = new ScottPlot.Plot();
            double[] valores = counts.Select(v => (double)v).ToArray();
            double[] posicoes = Enumerable.Range(0, valores.Length).Select(i => (double)i).ToArray();

            plt.Add.Bars(valores);

            plt.Axes.Bottom.SetTicks(posicoes, labels.ToArray());

            plt.Title("Distribuição de Números");
            plt.YLabel("Quantidade");
            plt.XLabel("Intervalos");

            plt.Axes.AutoScale();
            plt.Axes.Margins(bottom: 0.20);

            string chartPath = Path.Combine(folderPath, "grafico_temp.png");
            plt.SavePng(chartPath, 800, 400);

            string pdfPath = Path.Combine(folderPath, $"Distribuicao_{DateTime.Now:yyyyMMdd_HHmmss}.pdf");
            using (PdfDocument document = new PdfDocument())
            {
                document.Info.Title = "Distribuição de Números";
                PdfPage page = document.AddPage();
                XGraphics gfx = XGraphics.FromPdfPage(page);

                XFont fontTitulo = new XFont("Arial", 18);
                gfx.DrawString("Distribuição de Números", fontTitulo, XBrushes.Black,
                    new XRect(0, 30, page.Width, 50), XStringFormats.TopCenter);

                XImage image = XImage.FromFile(chartPath);
                double x = (page.Width - image.PixelWidth * 72 / image.HorizontalResolution) / 2;
                gfx.DrawImage(image, x, 100,
                    image.PixelWidth * 72 / image.HorizontalResolution,
                    image.PixelHeight * 72 / image.VerticalResolution);

                document.Save(pdfPath);
            }

            File.Delete(chartPath);

            Console.WriteLine($"PDF gerado com sucesso em: {pdfPath}");
        }
    }
}
