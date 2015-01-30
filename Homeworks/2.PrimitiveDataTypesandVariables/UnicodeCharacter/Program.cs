using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnicodeCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 72;
            Console.WriteLine("The hexadecimal representation of code 72 is: {0:X}", number);
            char symbol = '\u0048';
            Console.WriteLine("The symbol is: {0}", symbol);
        }
    }
}
