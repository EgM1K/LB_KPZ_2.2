using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_KPZ_2.Interfaces
{
    public interface IPrimeAlgorithm
    {
        List<int> FindPrimes(int n);
    }

    public interface IProgressNotifier
    {
        event EventHandler<int> ProgressUpdated;
    }

    public interface IResultDisplay
    {
        void ShowResults(List<int> primes);
    }
}
