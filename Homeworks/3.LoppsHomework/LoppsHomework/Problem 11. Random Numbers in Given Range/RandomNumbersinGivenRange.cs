using System;
using System.Linq;
    class RandomNumbersinGivenRange
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (min <= max)
            {
                Random random = new Random();

                for (int i = 0; i < n; i++)
                {
                    Console.Write(random.Next(min, max + 1) + " ");
                }

                Console.WriteLine();
            }

        }
    }
