using System;
namespace TaskConsoleInputOutput
{
    class SumOfIntegers
    {
        static void Main()
        { Console.WriteLine("Enter an integer:");
        int IntOne = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter an integer:");
        int IntTwo = int.Parse(Console.ReadLine());
 
        Console.WriteLine("Enter an integer:");
        int IntThree = int.Parse(Console.ReadLine());

        int sum = IntOne + IntTwo + IntThree;
 
        Console.WriteLine("The Sum of the integers is : {0}", sum);
        }
    }
}
