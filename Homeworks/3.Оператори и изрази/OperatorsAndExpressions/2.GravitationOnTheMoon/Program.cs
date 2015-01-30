using System;
namespace _2.GravitationOnTheMoon
{
    class Gravitation
    {
        static void Main()
        {
            Console.WriteLine("Enter weight of man on the Earth:");
            decimal WeighOnEarth = decimal.Parse(Console.ReadLine());
            decimal WeightOnMoon = WeighOnEarth * 0.17m;
            Console.WriteLine("The declared weight will be on the Moon:\n" + WeightOnMoon);
        }
    }
}
