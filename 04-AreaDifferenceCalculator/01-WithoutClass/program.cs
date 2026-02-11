using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC, areaX, areaY;

            Console.Write("Enter the measurements of the triangle x:\n\nSide A(meters): ");
            xA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B(meters): ");
            xB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C(meters): ");
            xC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nEnter the measurements of the triangle y:\n\nSide A(meters): ");
            yA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B(meters): ");
            yB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C(meters): ");
            yC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaX = area(xA, xB, xC);
            areaY = area(yA, yB, yC);

            Console.WriteLine("\nArea of the triangle x = " + areaX.ToString("F4", CultureInfo.InvariantCulture) + " meters");
            Console.WriteLine("Area of the triangle y = " + areaY.ToString("F4", CultureInfo.InvariantCulture) + " meters");

            if (areaX > areaY)
            {
                Console.WriteLine("\nLargest area: triangle X");
            }
            else if (areaX < areaY)
            {
                Console.WriteLine("\nLargest area: triangle Y");
            }
            else
            {
                Console.WriteLine("\nThe two triangles have the same area");
            }
        }

        static double area(double lado1, double lado2, double lado3)
        {

            double p = (lado1 + lado2 + lado3) / 2.0;
            return Math.Sqrt(p * (p - lado1) * (p - lado2) * (p - lado3));

        }
    }
}