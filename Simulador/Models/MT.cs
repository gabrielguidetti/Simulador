using Simulador.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Simulador.Models
{
    public class MT : IRNGenerator
    {
        private static readonly int N = 624;
        private static readonly int M = 397;
        private readonly UInt32 MATRIX_A = 0x9908b0df;
        private readonly UInt32 UPPER_MASK = 0x80000000;
        private readonly UInt32 LOWER_MASK = 0x7fffffff;
        private readonly UInt32 TEMPERING_MASK_B = 0x9d2c5680;
        private readonly UInt32 TEMPERING_MASK_C = 0xefc60000;
        private readonly double FINAL_CONSTANT = 2.3283064365386963e-10;

        public MT()
        {
        }

        private ulong TEMPERING_SHIFT_U(ulong y)
        {
            return y >> 11;
        }

        private ulong TEMPERING_SHIFT_S(ulong y)
        {
            return y << 7;
        }

        private ulong TEMPERING_SHIFT_T(ulong y)
        {
            return y << 15;
        }

        private ulong TEMPERING_SHIFT_L(ulong y)
        {
            return y >> 18;
        }

        private readonly ulong[] mt = new ulong[625];
        private int mti = N + 1;

        private void sgenrand(ulong seed)
        {
            mt[0] = seed & 0xffffffff;
            for (mti = 1; mti < N; mti++)
                mt[mti] = (69069 * mt[mti - 1]) & 0xffffffff;
        }

        private double genrand()
        {
            ulong y;
            ulong[] mag01 = new ulong[2] { 0x0, MATRIX_A };

            if (mti >= N)
            { 
                int kk;

                if (mti == N + 1)
                    sgenrand(4357);

                for (kk = 0; kk < N - M; kk++)
                {
                    y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                    mt[kk] = mt[kk + M] ^ (y >> 1) ^ mag01[y & 0x1];
                }
                for (; kk < N - 1; kk++)
                {
                    y = (mt[kk] & UPPER_MASK) | (mt[kk + 1] & LOWER_MASK);
                    mt[kk] = mt[kk + (M - N)] ^ (y >> 1) ^ mag01[y & 0x1];
                }
                y = (mt[N - 1] & UPPER_MASK) | (mt[0] & LOWER_MASK);
                mt[N - 1] = mt[M - 1] ^ (y >> 1) ^ mag01[y & 0x1];

                mti = 0;
            }

            y = mt[mti++];
            y ^= TEMPERING_SHIFT_U(y);
            y ^= TEMPERING_SHIFT_S(y) & TEMPERING_MASK_B;
            y ^= TEMPERING_SHIFT_T(y) & TEMPERING_MASK_C;
            y ^= TEMPERING_SHIFT_L(y);

            return ((double)y * FINAL_CONSTANT);
        }

        public double Generate()
        {
            return this.genrand();
        }

        public double Generate(int lowerBound, int higherBound)
        {
            if (higherBound < lowerBound)
            {
                return double.NaN;
            }
            return Convert.ToInt32(Math.Floor(this.Generate(lowerBound * 1.0d, higherBound * 1.0d)));
        }

        public double Generate(double lowerBound, double higherBound)
        {
            if (higherBound < lowerBound)
            {
                return double.NaN;
            }
            return (this.Generate() * (higherBound - lowerBound + 1)) + lowerBound;
        }

        public List<long> Generate(RandomConfig config)
        {
            sgenrand((ulong)config.SementeInicial);

            List<long> result = new List<long>();
            Process currentProcess = Process.GetCurrentProcess();

            for (int i = 0; i < config.Quantidade; i++)
            {
                if (config.MaxBytes != 0 && i % 1000 == 0)
                    if (currentProcess.PrivateMemorySize64 > config.MaxBytes)
                        config.MaxBytes = currentProcess.PrivateMemorySize64;

                result.Add((long)Generate(config.Minimo, config.Maximo));
            }

            return result;
        }
    }
}
