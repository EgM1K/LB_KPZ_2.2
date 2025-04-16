namespace LB_KPZ
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Пошук перших 10 простих чисел:");
            List<int> primes = FindPrimes(10);
            Console.WriteLine("Результат: " + string.Join(", ", primes));
        }

        static List<int> FindPrimes(int n)
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

            List<int> primes = new List<int>();
            for (int i = 0; i < sieve.Length; i++)
                if (sieve[i]) primes.Add(i);

            return primes;
        }
    }
}
