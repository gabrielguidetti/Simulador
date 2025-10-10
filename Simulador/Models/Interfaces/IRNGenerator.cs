using System.Collections.Generic;

namespace Simulador.Models.Interfaces
{
    public interface IRNGenerator
    {
        List<long> Generate(RandomConfig config);
    }
}
