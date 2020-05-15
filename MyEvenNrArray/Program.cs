using System;
using System.Net.Http.Headers;

namespace MyEvenNrArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter 10 numbers\nNr 1:");
            string nr1 = Console.ReadLine();

            Console.WriteLine("Nr 2:");
            string nr2 = Console.ReadLine();

            Console.WriteLine("Nr 3:");
            string nr3 = Console.ReadLine();

            Console.WriteLine("Nr 4:");
            string nr4 = Console.ReadLine();

            Console.WriteLine("Nr 5:");
            string nr5 = Console.ReadLine();

            Console.WriteLine("Nr 6:");
            string nr6 = Console.ReadLine();

            Console.WriteLine("Nr 7:");
            string nr7 = Console.ReadLine();

            Console.WriteLine("Nr 8:");
            string nr8 = Console.ReadLine();

            Console.WriteLine("Nr 9:");
            string nr9 = Console.ReadLine();

            Console.WriteLine("Nr 10:");
            string nr10 = Console.ReadLine();

            string[] numbers = { nr1, nr2, nr3, nr4, nr5, nr6, nr7, nr8, nr9, nr10 };
            int[] intNumbers = Array.ConvertAll(numbers, i => int.Parse(i));

            Console.WriteLine("Even Numbers :");

            int i;
           
            for (i = 0; i < intNumbers.Length; i++)
            {
                if (intNumbers[i] % 2 == 0)
                {
                    Console.WriteLine(intNumbers[i]);
                }
            }
        }
    }
}
