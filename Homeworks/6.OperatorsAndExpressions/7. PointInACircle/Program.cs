using System;
namespace _7.PointInACircle
{ //Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). 
    class Circle
    {
        static void Main()
        {
            Console.WriteLine("Enter the value of the coordinate x of the point:");
            decimal xPoint = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of the coordinate y of the point:");
            decimal yPoint = decimal.Parse(Console.ReadLine());
            decimal radious = 2;

            bool insideCircle = xPoint * xPoint + yPoint * yPoint <= radious * radious;
            Console.WriteLine("Is the given point in the circle?\n{0}", insideCircle);
        }
    }

}