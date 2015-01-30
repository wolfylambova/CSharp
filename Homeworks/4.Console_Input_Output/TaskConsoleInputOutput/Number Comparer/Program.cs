using System;
namespace Number_Comparer
{
    class Copmpare
    {
        static void Main()
        {
            Console.WriteLine("Enter a number :");
            double firstNum = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number :");
            double secondNum = double.Parse(Console.ReadLine());

            double maxNum = Math.Max(firstNum, secondNum);
            Console.WriteLine("The greater number is: {0}\n", maxNum);
        }
    }
}
