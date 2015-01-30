using System;
namespace _10.PointInsideCircleOutsideOfARectangle
{
class PointCheck
{
    static void Main()
    {   Console.WriteLine("Enter the value of the coordinate x of the point");
        decimal xPoint = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value of the coordinate y of the point");
        decimal yPoint = decimal.Parse(Console.ReadLine());
        decimal radious = 1.5m;
        bool CircleCheck = (xPoint - 1) * (xPoint - 1) + (yPoint - 1) * (yPoint - 1) <= radious * radious;
           
            if (CircleCheck && yPoint > 1)
                {   Console.WriteLine("The point is within the circle.");
                }
                else
                {   Console.WriteLine("The point is not within the circle.");
                }
    }
}
}
