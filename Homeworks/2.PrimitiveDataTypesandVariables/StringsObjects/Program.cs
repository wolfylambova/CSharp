using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            object combine = first + " " + second;
            string combination = (string)combine;
            Console.WriteLine(combination);
    }
}
