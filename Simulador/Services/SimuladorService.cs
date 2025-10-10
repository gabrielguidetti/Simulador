using Simulador.Models;
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

            CreateFile(numbers, config.FolderPath);

            CreateReport(numbers, config.FolderPath);

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
                Console.WriteLine($"Erro ao criar o arquivo: {ex.Message}");
            }
        }

        private static void CreateReport(List<long> numeros, string folderPath)
        {

        }
    }
}
