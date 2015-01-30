using System;
using System.Linq;

class ClacSum
{
    static void Main()
    {
        Console.WriteLine("Enter value of n: ");
        int n = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());

        double exponentX = 1;
        double result = 1;
        double factorial = 1;

        if (n <= 0 || n <= 1)
        {

            result = 1;
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
                exponentX *= x;
                result += factorial / exponentX;
             }
            Console.WriteLine("{0:F5}", result);
        }      
    }
}

