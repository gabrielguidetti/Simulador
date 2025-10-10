using Simulador.Models.Interfaces;
using System.Collections.Generic;

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

            for (int i = 0; i < config.Quantidade; i++)
            {
                actual = Next();
                result.Add((actual % range) + config.Minimo);
            }
            
            return result;
        }
    }
}
