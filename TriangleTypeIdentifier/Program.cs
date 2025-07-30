using System;

namespace TriangleTypeIdentifier
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1: ");
            double side1 = ReadPositiveDouble();

            Console.Write("Enter side 2: ");
            double side2 = ReadPositiveDouble();

            Console.Write("Enter side 3: ");
            double side3 = ReadPositiveDouble();

            string type = GetTriangleType(side1, side2, side3);
            Console.WriteLine($"The triangle is: {type}");
        }

        static double ReadPositiveDouble()
        {
            if (double.TryParse(Console.ReadLine(), out double value) && value > 0)
                return value;

            Console.WriteLine("Invalid input. Please enter a positive number.");
            Environment.Exit(0);
            return 0; // unreachable
        }

        static string GetTriangleType(double a, double b, double c)
        {
            if (a == b && b == c) return "Equilateral";
            else if (a == b || b == c || a == c) return "Isosceles";
            else return "Scalene";
        }
    }
}