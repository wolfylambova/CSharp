using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Trapezoids
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter side a of the Trapezoid:");
            decimal a = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter side b of the Trapezoid:");
            decimal b = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Height of the Trapezoid:");
            decimal height = decimal.Parse(Console.ReadLine());
            decimal area = ((b + b) / 2) * height;
            Console.WriteLine("The trapezoid's area is: " + area);
        }
    }
}
