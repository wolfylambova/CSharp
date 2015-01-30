using System;

namespace _4.Rectangles
{
    class PerimeterAndWidth
    {
        static void Main()
        {
            Console.WriteLine("Enter the width of the rectangle:");
            decimal width = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the height of the rectangle:");
            decimal height = decimal.Parse(Console.ReadLine());

            decimal area = width * height;
            decimal perimeter = 2 * (width + height);

            Console.WriteLine("The perimeter is:\n" + perimeter);
            Console.WriteLine("The Area is:\n" + area);
       
        }
    }
}
