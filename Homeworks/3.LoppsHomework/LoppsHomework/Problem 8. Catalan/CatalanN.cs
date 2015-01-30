using System;
using System.Linq;
using System.Numerics;

   class CatalanN
    { 
       static void Main()
        {
            int n = int.Parse(Console.ReadLine());
        BigInteger upperFactorial = 1;
        BigInteger lowerFactorial = 1;
 
        for (int i = n + 2; i <= n * 2; i++)
        {
            upperFactorial *= i;
        }
        for (int j = 1; j <= n; j++)
        {
            lowerFactorial *= j;
        }
        BigInteger catalan = upperFactorial / lowerFactorial;
        Console.WriteLine(catalan);
    }
        }
    

//(2n)!/((n+1)!*n!
//1 < n < 100