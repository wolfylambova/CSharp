using System;
namespace Fibonacci_Numbers
{
    class FibonaciFun
    {
        static void Main()
        {
            Console.WriteLine("Enter the last member of the sequence:");
            int count = int.Parse(Console.ReadLine());

            decimal first = 0m;
            decimal second = 1m;
            decimal sum;

            for (int k = 0; k < count; k++)
            {
                Console.Write("{0} ", first);
                sum = first + second;
                first = second;
                second = sum;
            }
        }
    }
}
