using LB_KPZ_2.Interfaces;

namespace LB_KPZ_2.Algorithms
{
    public class EratosthenesSieve : IPrimeAlgorithm
    {
        public List<int> FindPrimes(int n)
        {

            bool[] sieve = new bool[n + 1];
            Array.Fill(sieve, true);
            sieve[0] = sieve[1] = false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (sieve[i])
                {
                    for (int j = i * i; j <= n; j += i)
                        sieve[j] = false;
                }
            }

            return sieve.Select((isPrime, index) => new { isPrime, index })
                        .Where(x => x.isPrime)
                        .Select(x => x.index)
                        .ToList();
        }
    }
}
