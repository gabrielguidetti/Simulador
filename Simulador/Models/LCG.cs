namespace Simulador.Models
{
    public class LCG
    {
        private long _seed;
        private readonly long _multiplier;
        private readonly long _increment;
        private readonly long _modulus;

        public LCG(long seed, long multiplier, long increment, long modulus)
        {
            _seed = seed;
            _multiplier = multiplier;
            _increment = increment;
            _modulus = modulus;
        }

        public long Next()
        {
            _seed = (_multiplier * _seed + _increment) % _modulus;
            return _seed;
        }
    }
}
