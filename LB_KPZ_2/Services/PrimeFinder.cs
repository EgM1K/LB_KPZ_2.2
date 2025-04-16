using LB_KPZ_2.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_KPZ_2.Services
{
    public class PrimeFinder : IProgressNotifier
    {
        private readonly IPrimeAlgorithm _algorithm;
        public event EventHandler<int> ProgressUpdated;
        public event EventHandler<List<int>> PrimesFound;

        public PrimeFinder(IPrimeAlgorithm algorithm)
        {
            _algorithm = algorithm;
        }

        public void CalculatePrimes(int n)
        {
            var stopwatch = Stopwatch.StartNew();
            var memoryBefore = GC.GetTotalMemory(false);

            if (n < 2)
                throw new ArgumentException("n має бути більше 1");
            for (int i = 0; i <= 100; i += 10)
            {
                ProgressUpdated?.Invoke(this, i);
                Thread.Sleep(100);
            }

            List<int> primes = _algorithm.FindPrimes(n);
            PrimesFound?.Invoke(this, primes);

            stopwatch.Stop();
            var memoryUsed = GC.GetTotalMemory(false) - memoryBefore;

            Debug.WriteLine($"Час: {stopwatch.ElapsedMilliseconds} мс | Пам'ять: {memoryUsed} байт");
        }
    }
}
