using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            int varA = 5;
            int varB = 10;
            Console.WriteLine("Before\n" + varA);
            Console.WriteLine(varB);

            int varC = varA;
            varA = varB;
            varB = varC;

            Console.WriteLine("After\n" + varA);
            Console.WriteLine(varB);
        }
    }
}
