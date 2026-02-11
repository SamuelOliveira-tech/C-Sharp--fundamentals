using System;
using System.Collections.Generic;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "0";
            int    quantnumeros = 0;
            List<int> numeros = new List<int>(); // List for dynamically storing entered numbers.

            Console.WriteLine("Enter as many numbers as you want to sort them.:\n(To finish typing, press the enter key)\n");

            while (x != "") {

                Console.Write("-->");
                x = Console.ReadLine();

                if (x != "") {
                    numeros.Add(int.Parse(x));
                }

            }

            Console.WriteLine("\nClassification of the numbers entered:\n");

            foreach (int n in numeros)
            {
                y++;
                Console.Write($"Number {quantnumeros}: {n} ");

                if (n % 2 == 0) {
                    Console.WriteLine($"is even.");
                }
                else {
                    Console.WriteLine($"is odd.");
                }
            }



        }
    }
}