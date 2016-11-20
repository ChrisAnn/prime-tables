using System;

namespace PrimeTables
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Table Size:");
            var readLine = Console.ReadLine();

            int tableSize;
            if (!int.TryParse(readLine, out tableSize))
            {
                Console.WriteLine("Not a valid integer.");
                return;
            }

            Console.WriteLine($"Table Size: {tableSize}");
        }
    }
}
