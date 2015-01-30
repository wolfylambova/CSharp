using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Victoria";
            string middleName = "Lubomirova"
            string lastName = "Lambova";
            decimal moneyBalance = 378893.50m;
            string NameOfBank = "FiBank";
            string ibancode = "EN54 UBBS 2341 8745 1111 99";
            long FirstCard = 345678912312509;
            long SecondCard = 654387345621290;
            long ThirdCard = 345683612789574;
            Console.WriteLine("{0} {1} {2}\nAvailable amount of money: {3}\n{4} IBAN:{5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, moneyBalance, NameOfBank, iban, FirstCard, SecondCard,  ThirdCard);
        }
    }
}
