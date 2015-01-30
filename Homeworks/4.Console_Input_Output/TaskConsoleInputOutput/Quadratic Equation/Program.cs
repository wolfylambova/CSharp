using System;
namespace Quadratic_Equation
{
    class SolveMe
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of the coefficient a :");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of the coefficient b :");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the value of the coefficient c :");
            double c = double.Parse(Console.ReadLine());

            double discriminant = (b * b) - 4 * a * c;

            if (discriminant < 0)
            {
                Console.WriteLine("There are no real roots");
            }
            else
            {
                double rootDiscriminant = Math.Sqrt(discriminant);
                double x1 = (-b + rootDiscriminant) / (2 * a);
                double x2 = (-b - rootDiscriminant) / (2 * a);
                Console.WriteLine(x1 == x2 ? "The Equasion got one real root {0}" : "The Equasion got two real roots {0} {1}", x1, x2);
            }
        }
    }
}