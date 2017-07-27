using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Table Size:");
            var readLine = Console.ReadLine();

            int size;
            if (!int.TryParse(readLine, out size) || size < 1)
            {
                Console.WriteLine("Not a valid integer.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("Table Size: {0}", size);

            var estimatedPrimeAtSize = EstimatePrimeAtN(size);
            var primes = EratosthenesSieve.SievePrimes(estimatedPrimeAtSize);

            PrintGrid(primes.Take(size).ToList());
            Console.ReadLine();
        }

        private static int EstimatePrimeAtN(int n)
        {
            if (n >= 6)
            {
                return (int)Math.Ceiling(n * Math.Log(n) + n * Math.Log(Math.Log(n)));
            }

            return new[] { 2, 3, 5, 7, 11 }[n - 1];
        }

        private static void PrintGrid(IList<int> primes)
        {
            for (var row = 0; row <= primes.Count; row++)
            {
                var rowString = row == 0 ? "|      |" : string.Format("|{0,5} |", primes[row - 1]);

                foreach (var column in primes)
                {
                    rowString += row == 0 ? string.Format("{0,5} |", column) : string.Format("{0,5} |",
                        primes[row - 1] * column);
                }
                Console.WriteLine(rowString);
            }
        }
    }
}
