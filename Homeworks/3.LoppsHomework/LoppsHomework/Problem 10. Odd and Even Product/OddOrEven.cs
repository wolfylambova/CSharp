using System;
using System.Linq;

    class OddOrEven
    {
        static void Main()
        {
             int sumOdd = 1;
             int sumEven = 1;

             string sequenceStr = Console.ReadLine();           
             string[]  numbers = sequenceStr.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                  
            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);

                if (i % 2 == 0)
                {
                    sumEven *= number;
                }
                else
                {
                    sumOdd *= number;
                }
            }

            if (sumOdd == sumEven)
            {
                Console.WriteLine("yes\n product = {0} ", sumOdd);
            }
            else
            {
                Console.WriteLine("no\n odd_product= {0}\n even_product= {1}", sumOdd, sumEven);
            }
         }
    }

