using System;
namespace Print_Company_Information
{
    class Information
    {
        static void Main()
        {
            Console.WriteLine("Enter name of the company:");
            string nameCompany = Console.ReadLine();
            Console.WriteLine("Enter adress of the company:");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the phone number of the company:");
            string PhoneCompany = Console.ReadLine();
            Console.WriteLine("Enter the fax number of the company:");
            string fax = Console.ReadLine();
            Console.WriteLine("Enter the web site of the company:");
            string web = Console.ReadLine();
            Console.WriteLine("Enter the first name of the manager:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter the second name of the manager:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter the age of the manager:");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter the phone of the manager:");
            string PhoneManager = Console.ReadLine();

            string text = "(no fax)";
            bool isFax = String.IsNullOrEmpty(fax);
            Console.WriteLine("{0}\nAddress: {1}\nTel. {2}\nFax: {3}\nWeb site: {4}", nameCompany, address, honeCompany, isFax ? text : fax, web);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", firstName, lastName, age, PhoneManager);
        }
    }
}
