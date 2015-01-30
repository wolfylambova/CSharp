using System;
namespace Sum_of_n_Numbers
{
    class SumOfNumbers
            {
        static void Main()
        {
            Console.WriteLine("Declare how many numbers do you intend to enter: ");
            int numb = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int k = 0; k < numb; k++)
            {
                Console.WriteLine("Enter a number");
                int value = int.Parse(Console.ReadLine());
                sum += value;
            }
            Console.WriteLine("The sum of the {0} numbers is {1}", numb, sum);
        }
    }
}
