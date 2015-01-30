using System;
using System.Linq;

class Matrix
{
    static void Main()
    {
        Console.Write("Declare an integer in the range [1...20]: ");
        string numberStr = Console.ReadLine();
        int n = int.Parse(numberStr);
        if (n < 1 || n > 20)
        {
            Console.WriteLine("Error");
        }
        else
        {
            Console.WriteLine("Your matrix looks like:");
            Console.WriteLine();
            for (int row = 1; row <= n; row++)
            {
                for (int col = row; col < n + row; col++)
                {
                    Console.Write("{0,2} ", col);
                }
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}

