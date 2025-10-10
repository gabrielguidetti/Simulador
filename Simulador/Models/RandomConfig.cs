using Simulador.Models.Enums;

namespace Simulador.Models
{
    public class RandomConfig
    {
        public EGeradores Gerador { get; set; }
        public long Minimo { get; set; }
        public long Maximo { get; set; }
        public long SementeInicial { get; set; }
        public long Multiplicador { get; set; }
        public long Incremento { get; set; }
        public long Quantidade { get; set; }
        public long Modulo { get; set; }
    }
}
