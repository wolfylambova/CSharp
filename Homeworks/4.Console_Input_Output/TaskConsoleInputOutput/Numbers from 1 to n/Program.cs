using System;
namespace Numbers_from_1_to_n
{
    class From1ToN
    {
        static void Main()
        { Console.WriteLine("Enter a number:");
          int number = int.Parse(Console.ReadLine());
        
            for (int i = 1; i <= number; i++)
             { Console.WriteLine(i);
             }
        }
}
