using Simulador.Models;
using Simulador.Models.Enums;
using Simulador.Models.Interfaces;
using System.Collections.Generic;

namespace Simulador.Services
{
    public static class RandomNumberService
    {
        public static List<long> Random(RandomConfig config)
        {
            IRNGenerator generator = null;

            if (config.Gerador == EGeradores.LINEAR_CONGRUENTIAL_GENERATOR)
            {
                generator = new LCG();
            }
            else if (config.Gerador == EGeradores.MERSENNE_TWISTER)
            {
                generator = new MT();
            }
            else if (config.Gerador == EGeradores.RANDOM_NUMBER_GENERATOR)
            {
                generator = new RNG();
            }

            List<long> result = generator.Generate(config);

            return result;
        }
    }
}
