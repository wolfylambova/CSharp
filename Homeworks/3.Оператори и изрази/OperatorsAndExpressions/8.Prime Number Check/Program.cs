using System;
namespace _8.Prime_Number_Check
{
class Check
    {
    static void Main()
    {
    int n = int.Parse(Console.ReadLine());
    bool IsPrime = true;

    if (n>=1)
    {
    for (int i = 2; i < n; i++)
    {
    if (n%i == 0)
    {
    IsPrime = false;
    }
    }
    Console.WriteLine(IsPrime);
    }

    else
    {
    Console.WriteLine("false");
    }
    }
    }
    }
