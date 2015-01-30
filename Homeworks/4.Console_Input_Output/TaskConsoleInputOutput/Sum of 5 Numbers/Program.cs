using System;
namespace Sum_of_5_Numbers
{
    class SumOfFive
    {
        static void Main()
            
             { Console.WriteLine("Enter 5 numbers (given in a single line, separated by a space) :");
               string strNumbers = Console.ReadLine();
               string[] Numbers = strNumbers.Split(new char[] { '\u0020' }, StringSplitOptions.RemoveEmptyEntries);
                double first = double.Parse(Numbers[0]);
                double second = double.Parse(Numbers[1]);
                double third = double.Parse(Numbers[2]);
                double fourth = double.Parse(Numbers[3]);
                double fifth = double.Parse(Numbers[4]);
                double sum = first + second + third + fourth + fifth;

                 Console.WriteLine("The sum of {0},{1},{2},{3} and {4} is:\n{5}" , first, second, third, fourth, fifth, sum);
               }
    }
}
