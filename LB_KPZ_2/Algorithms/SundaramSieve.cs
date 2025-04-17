using LB_KPZ_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_KPZ_2.Algorithms
{
    public class SundaramSieve : IPrimeAlgorithm
    {
        public List<int> FindPrimes(int n)
        {
            if (n <= 0)
                throw new ArgumentException("n must be greater than 0.");

            if (n < 2)
                return new List<int>();

            int k = (n - 1) / 2;
            var sieve = new bool[k + 1];
            Array.Fill(sieve, true);

            for (int i = 1; i <= Math.Sqrt(k); i++)
                for (int j = i; j <= (k - i) / (2 * i + 1); j++)
                    sieve[i + j + 2 * i * j] = false;

            var primes = sieve.Select((isPrime, idx) => isPrime ? 2 * idx + 1 : 0)
                              .Where(x => x > 1 && x <= n)
                              .ToList();

            primes.Insert(0, 2);

            return primes;
        }
    }
}