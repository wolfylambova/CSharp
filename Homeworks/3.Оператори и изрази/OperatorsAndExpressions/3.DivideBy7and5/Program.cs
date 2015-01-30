using System;

namespace _3.DivideBy7and5
{
    class DivideMe
    {
        static void Main()
        {
            Console.WriteLine("Declare an integer number:");
            int num = int.Parse(Console.ReadLine());
            bool division = num % 35 == 0 && num != 0;
            Console.WriteLine("See whether the number can be divided by 7 and 5 at the same time?  (without remainder) \n{0}", isDivided);
        }
    }
}
