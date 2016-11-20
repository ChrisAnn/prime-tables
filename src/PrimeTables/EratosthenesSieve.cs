using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeTables
{
    public class EratosthenesSieve
    {
        public static IList<int> SievePrimes(int max)
        {
            var primes = new List<int>();
            var sieve = CreateSieve(max);

            for (var i = 2; i <= max; i++)
            {
                if (sieve[i])
                    primes.Add(i);
            }
            
            return primes;
        }

        private static bool[] CreateSieve(int max)
        {
            var isPrime = Enumerable.Repeat(true, max + 1).ToArray();

            var squareRootMax = Math.Ceiling(Math.Sqrt(max));

            for (var i = 2; i <= squareRootMax; i++)
            {
                if (!isPrime[i]) continue;

                for (var j = i*2; j < max; j += i)
                {
                    isPrime[j] = false;
                }
            }

            return isPrime;
        }
    }
}