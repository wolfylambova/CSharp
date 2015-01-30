using System;
namespace Check 
{
    class CheckBitatGivenPosition
    {
        static void Main()
        {   //Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
           // in given integer number n has value of 1. 
            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            bool isoOne = ((1 << p) & number) > 0;
            Console.WriteLine(isoOne);
            
            
            //way2:
            //uint mask = 1;

            //if (((mask << p) & number) == 0)
            //{
            //    Console.WriteLine("0");
            //}
            //else
            //{
            //    Console.WriteLine("1");
            //}
        }
    }
}
