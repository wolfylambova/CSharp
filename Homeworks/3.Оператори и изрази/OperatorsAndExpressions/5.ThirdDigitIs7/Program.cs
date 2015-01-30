using System;
namespace _5.ThirdDigitIs7
{
    class DigitCheck
    {
        static void Main()
        {   Console.WriteLine("Enter an integer number:");
        int numb = int.Parse(Console.ReadLine());
        int turnToDigit = numb / 100;
        int DigitThree = turnToDigit % 10;
        bool seven = DigitThree == 7;
        Console.WriteLine("Is the third digit 7?\n" + seven);
        }
    }
}
