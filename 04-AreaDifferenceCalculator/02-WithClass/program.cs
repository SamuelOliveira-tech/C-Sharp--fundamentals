using System;
using System.Globalization;
using TriangleCalculatorWithClass;


namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.Write("Enter the measurements of the triangle x:\n\nSide A(meters): ");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B(meters): ");
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C(meters): ");
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("\nEnter the measurements of the triangle y:\n\nSide A(meters): ");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side B(meters): ");
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Side C(meters): ");
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = area(x.A, x.B, x.C);
            double areaY = area(y.A, y.B, y.C);

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