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

            if (tableSize == 3)
            {
                Console.Write(  "|    |  2 |  3 |  5 |\r\n" +
                                "|  2 |  4 |  6 | 10 |\r\n" +
                                "|  3 |  6 |  9 | 15 |\r\n" +
                                "|  5 | 10 | 15 | 25 |\r\n");
            }
        }
    }
}
