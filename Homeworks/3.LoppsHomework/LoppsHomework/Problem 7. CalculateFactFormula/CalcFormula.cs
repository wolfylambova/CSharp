using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_7.CalculateFactFormula
{
    class CalcFormula
    {
              static long Factorial(long k)
                  {
                    if (k <= 1 )
                       return 1;
                    else
                      return k * Factorial(k - 1);
                   }

                 static void Main()
                 {
                     Console.WriteLine("Enter n:");
                     int n = int.Parse(Console.ReadLine());
                     Console.WriteLine("Enter k:");
                     int k = int.Parse(Console.ReadLine());
                     decimal result = 1;

                     if (k > 1 && k < n && n < 100)
                     {
                         //n! / (k! * (n-k)!
                         result = (Factorial(n)) / ((Factorial(k))*(n-k));
                         Console.WriteLine(result);
                     }
                     else
                     {
                         Console.WriteLine("You have entered a wrong number. Read the task again and follow the instructions (1 < k < n < 100).");
                     }

                 }
        }
    }


