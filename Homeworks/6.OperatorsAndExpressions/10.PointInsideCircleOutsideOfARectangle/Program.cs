using System;
namespace _10.PointInsideCircleOutsideOfARectangle
{
class PointCheck
{
static void Main()
{
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());

    bool IsIntheCircle = (Math.Pow(x-1, 2) + Math.Pow(y-1,2))<=Math.Pow(1.5, 2);
    bool insideRectangle = (x >= -1 &&x <=5) && (y >= -1 && y <=1);

    if (IsIntheCircle == true && insideRectangle != true)
{
Console.WriteLine("yes");
}
else
{
Console.WriteLine("no");
}

}
}

    }



    //{   Console.WriteLine("Enter the value of the coordinate x of the point");
     
    //    decimal xPoint = decimal.Parse(Console.ReadLine());
    //    Console.WriteLine("Enter the value of the coordinate y of the point");
    //    decimal yPoint = decimal.Parse(Console.ReadLine());
    //    decimal radious = 1.5m;
    //    bool CircleCheck = (xPoint - 1) * (xPoint - 1) + (yPoint - 1) * (yPoint - 1) <= radious * radious;
           
    //        if (CircleCheck && yPoint > 1)
    //            {   Console.WriteLine("The point is within the circle.");
    //            }
    //            else
    //            {   Console.WriteLine("The point is not within the circle.");

    //            }