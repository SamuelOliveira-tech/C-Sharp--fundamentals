using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            int numberOfBedrooms;
            double productPrice;
            string lastName;
            int age;
            double height;

            Console.Write("Enter your full name: ");
            firstName = Console.ReadLine();
            Console.Write("How many bedrooms are in your house? ");
            numberOfBedrooms = int.Parse(Console.ReadLine());
            Console.Write("Enter the price of a product: ");
            productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Enter your last name, age, and height (same line): ");

            string[] inputs = Console.ReadLine().Split(' ');
            lastName = inputs[0];
            age = int.Parse(inputs[1]);
            height = double.Parse(inputs[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFull Name: {firstName}\nNumber of Bedrooms: {numberOfBedrooms}\nProduct Price: {productPrice:F2}");
            Console.WriteLine($"Last Name: {lastName}\nAge: {age}\nHeight: {height.ToString("F2")}");
        }
    }
}