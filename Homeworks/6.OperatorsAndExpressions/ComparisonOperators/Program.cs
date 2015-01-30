using System;
{
namespace Operations;
{
class OddOrEven
{
    static void Main()
    { Console.WriteLine("Declare an integer number:");
      int num = int.Parse(Console.ReadLine());
         if (num % 2 != 0)
        {
            Console.WriteLine("{0} is odd.", num);
        }
        else
        {
            Console.WriteLine("{0} is even.", num);
        }
    }
}
}
}
