using System;
namespace _11.ExtractBitNumber3
{
    class Bit3Check
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            uint mask = 1;

            if ((mask << 3 & number) == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
            //way 2:
            //Console.WriteLine("Declare an unsigned integer:");
            //uint unsigned = uint.Parse(Console.ReadLine());
            //Console.WriteLine("Binary representation of the unsigned integer is:");
            //Console.WriteLine(Convert.ToString(unsigned, 2).PadLeft(16, '0'));
            //uint moveNumber = unsigned >> 3;
            //uint bit = moveNumber & 1;
            //Console.WriteLine("The value of bit #3 is:");
            //Console.WriteLine(Convert.ToString(bit, 2));
        }
    }
}
