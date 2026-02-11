using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product1 = "Computer";
            string product2 = "Office desk";

            byte age = 30;
            int code = 5290;
            char gender = 'M';

            double price1 = 2100.0;
            double price2 = 650.50;
            double measurement = 53.234567;

            // Using Place Holder
            Console.WriteLine("Products:\n{0}, with a price of $ {1:F2}\n{2}, with a price of $ {3:F2} \n", product1, price1, product2, price2);

            // Using Concatenation
            Console.WriteLine("Record: " + age + " years old, code " + code + " and gender: " + gender + "\n");

            // Using String Interpolation
            Console.WriteLine($"Measurement with eight decimal places: {measurement:F8}\nRounded (three decimal places): {measurement:F3}");
            Console.WriteLine($"Decimal separator with invariant culture: {measurement.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}