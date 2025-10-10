using Simulador.Models.Interfaces;
using System.Collections.Generic;
using System.Diagnostics;

namespace Simulador.Models
{
    public class LCG : IRNGenerator
    {
        private long _seed;
        private long _multiplier;
        private long _increment;
        private long _modulus;

        public LCG()
        {
        }

        private long Next()
        {
            _seed = (_multiplier * _seed + _increment) % _modulus;
            return _seed;
        }

        public List<long> Generate(RandomConfig config)
        {
            _seed = config.SementeInicial;
            _multiplier = config.Multiplicador;
            _increment = config.Incremento;
            _modulus = config.Modulo;

            List<long> result = new List<long>();
            long actual = 0;
            long range = config.Maximo - config.Minimo + 1;
            Process currentProcess = Process.GetCurrentProcess();

            for (int i = 0; i < config.Quantidade; i++)
            {
                if(config.MaxBytes != 0 && i % 1000 == 0)
                    if(currentProcess.PrivateMemorySize64 > config.MaxBytes)
                        config.MaxBytes = currentProcess.PrivateMemorySize64;

                actual = Next();
                result.Add((actual % range) + config.Minimo);
            }
            
            return result;
        }
    }
}
