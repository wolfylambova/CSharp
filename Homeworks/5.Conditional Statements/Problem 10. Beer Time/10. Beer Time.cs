using System;
namespace Problem_10.Beer_Time
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Come on, tell me the time..");
            DateTime date = DateTime.Parse(Console.ReadLine());
           
            DateTime start = DateTime.Parse("1:00 PM");
            DateTime end = DateTime.Parse("3:00 PM");
            if (date.Hour >= start.Hour && date.Hour < end.Hour)
            {
                Console.WriteLine("Wohooo, It is beer time!");
            }
            else
            {
                Console.WriteLine("Sorry, non-beer time yet.");
            }
        }
    }
}
