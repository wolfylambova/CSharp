using System;
namespace _12.Extract_Bit_from_Integer
{
    class BitFromInt
    {
        static void Main()
        {       
            //{   Console.WriteLine("Declare an integer number:");
        //    int number = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Enter index p:");
        //    int p = int.Parse(Console.ReadLine());
        //    Console.WriteLine("Binary representation of the number is:");
        //    Console.WriteLine(Convert.ToString(number, 2).PadLeft(16, '0'));
        //    int newposition = number >> p;
        //    int bit = newposition & 1;
        //    Console.WriteLine("The value of the given bit at index p is:");
        //    Console.WriteLine(Convert.ToString(bit, 2));

            uint number = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            uint mask = 1;

            if ((mask << p & number) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
