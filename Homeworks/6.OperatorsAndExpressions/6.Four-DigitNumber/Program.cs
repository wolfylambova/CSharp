using System;
namespace _6.Four_DigitNumber
   { //Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
     //Calculates the sum of the digits (in our example 2+0+1+1 = 4).
     //Prints on the console the number in reversed order: dcba (in our example 1102).
     //Puts the last digit in the first position: dabc (in our example 1201).
     //Exchanges the second and the third digits: acbd (in our example 2101).
     //The number has always exactly 4 digits and cannot start with 0. 
    class DigitCount
    {
        static void Main()
        {
            Console.WriteLine("Enter a four-digit number:");
            int num = int.Parse(Console.ReadLine());
            if (num > 9999 || num < 1000)
            { Console.WriteLine("Please, try again! The entered number must be exactly 4 digits and cannot start with 0.");
            }
            else
            {   int firstNum = num / 1000;
                int secondNum = (num / 100) % 10;
                int thirdNum = (num / 10) % 10;
                int fourthNum = num % 10;
                int sum = firstNum + secondNum + thirdNum + fourthNum;

                Console.WriteLine("Sum of digits is: " + sum);
                Console.WriteLine("Your number in reversed order: {0} {1} {2} {3}", fourthNum, thirdNum, secondNum, firstNum);
                Console.WriteLine("Last digit in position one: {0} {1} {2} {3}", fourthNum, firstNum, secondNum, thirdNum);
                Console.WriteLine("Your number with second and the third digits exchanged: {0} {1} {2} {3}", firstNum, thirdNum, secondNum, fourthNum);
            }
        }
    }
}
