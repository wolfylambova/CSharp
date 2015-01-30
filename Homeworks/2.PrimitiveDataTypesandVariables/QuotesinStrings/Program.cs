using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesinStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstQuote = "The \"use\" of quotations causes difficulties.";
            string secondQuote = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(firstQuote + "\n" + secondQuote);
        }
    }
}
