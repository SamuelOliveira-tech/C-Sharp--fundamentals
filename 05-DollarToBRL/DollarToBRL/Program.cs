using DollarToBRL;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal exchangeRate = 0.0m;
            decimal amountInDollars = 0.0m;

            Console.Write("What is the exchange rate between the dollar and the real? ");
            exchangeRate = decimal.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.Write("\nHow many dollars do you want to convert to reais? USD ");
            amountInDollars = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            decimal reais = ConversorDeMoeda.Conversion(exchangeRate, amountInDollars); 

            Console.WriteLine("\nEstimated amount to be paid in reais (including IOF) = BRL " + reais.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}