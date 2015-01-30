using System;
using System.Linq;

namespace MinMaxNumbers
{
    class MAxMin
    {
        static void Main()
        {
            Console.Write("Enter the amount of numbers: ");
            int length = int.Parse(Console.ReadLine());

            int min = int.MinValue;
            int max = int.MaxValue;
            double sum = 0;
            double average = 0;

            for (int i = 0; i < length; i++)
            { 
                int number = int.Parse(Console.ReadLine());
               min = Math.Min(min, number);
               max = Math.Max(max, number);
               sum += number;
               average = sum / length; 

            }

            Console.WriteLine("Minimum Value =", min);
               Console.WriteLine("Maximum Value =", max);
               Console.WriteLine("Sum =", sum);
               Console.WriteLine("Avg = {0:F2}", average);       
            }

        }
    }



// Array: way2
////   Console.Write("Enter the amount of numbers: ");
//        int n = int.Parse(Console.ReadLine());
//        double[] numbers = new double[n];
//        for(int i =0;i<n;i++)
//        {
//            Console.Write("Enter number {0}: ",i+1);
//            numbers[i] = double.Parse(Console.ReadLine());
//        }
//        double average = numbers.Average();
//        Console.WriteLine("min = {0}", numbers.Min());
//        Console.WriteLine("max = {0}", numbers.Max());
//        Console.WriteLine("sum = {0}", numbers.Sum());
//        Console.WriteLine("avg = {0:0.00}",average);