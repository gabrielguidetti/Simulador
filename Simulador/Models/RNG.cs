using Simulador.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Simulador.Models
{
    public class RNG : IRNGenerator
    {
        public RNG()
        {
        }

        public List<long> Generate(RandomConfig config)
        {
            List<long> result = new List<long>();
            byte[] uint32Buffer = new byte[4];
            uint scale = 0;
            Process currentProcess = Process.GetCurrentProcess();

            using (var rng = new RNGCryptoServiceProvider())
            {
                for (int i = 0; i < config.Quantidade; i++)
                {
                    if (config.MaxBytes != 0 && i % 1000 == 0)
                        if (currentProcess.PrivateMemorySize64 > config.MaxBytes)
                            config.MaxBytes = currentProcess.PrivateMemorySize64;

                    rng.GetBytes(uint32Buffer);
                    scale = BitConverter.ToUInt32(uint32Buffer, 0);
                    result.Add((long)(config.Minimo + ((config.Maximo + 1) - config.Minimo) * (scale / (double)uint.MaxValue)));
                }
            }

            return result;
        }
    }
}
