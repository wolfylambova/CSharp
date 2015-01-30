using System;
namespace Problem_5.The_Biggest_of_3_Numbers
{
    class BiggestNum
    {
        static void Main(string[] args)
        {   decimal numberA = decimal.Parse(Console.ReadLine());
            decimal numberB = decimal.Parse(Console.ReadLine());
            decimal numberC = decimal.Parse(Console.ReadLine());

     
        decimal biggest = numberB;
        if (numberA > numberB)
        {
            biggest = numberA;
        }
        if (numberC > biggest)
        {
            biggest = numberC;
        }
        Console.WriteLine(biggest);
        }
    }
}



//double a = double.Parse(Console.ReadLine());
//            double b = double.Parse(Console.ReadLine());
//           double c = double.Parse(Console.ReadLine());
// 
//            if (a > b)
//           {
//               if (a > c)
//               {
//                  Console.WriteLine("{0}", a);
//               }
//           }
//          else if (b > a)
//            {
//               if (b > c)
//               {
//                    Console.WriteLine("{0}", b);
//                }
//            else if (c > a)
//           {
//               if (c > b)
//                {
//                    Console.WriteLine("{0}", c);
//              }