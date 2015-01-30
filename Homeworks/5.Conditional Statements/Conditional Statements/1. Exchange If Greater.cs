using System;
namespace Conditional_Statements
{
    class Greater
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int second = int.Parse(Console.ReadLine());

            if ( first < second)
                Console.WriteLine("{0} {1}", second, first);
            else
            {
                Console.WriteLine("{0} {1}", first, second);
            }
        }
    }
}
