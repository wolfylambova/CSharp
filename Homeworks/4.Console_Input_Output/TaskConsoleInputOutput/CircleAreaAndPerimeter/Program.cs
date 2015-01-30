using System;
namespace CircleAreaAndPerimeter
{
    class Circle
    {
        static void Main()
        {   Console.WriteLine("Enter the value of the circle's radius:");
            double radius = double.Parse(Console.ReadLine());
            double perimeter = 2 * Math.PI * radius;
            double area = Math.PI * radius * radius;
            Console.WriteLine("Perimeter: {0:F2}\nArea: {1:F2}", perimeter, area);
        }
    }
}
