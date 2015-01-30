using System;
namespace Contest_11April2014_Evening
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            int area = row * col;

             if (type == "Premiere")
            {
               double costs = 12.00;
               double incomes = (double)area * costs;
               Console.WriteLine("{0:00.00} leva", incomes);
            }
            if (type == "Normal")
            {
               double costs = 7.50;
               double incomes = (double)area * costs;
               Console.WriteLine("{0:00.00} leva", incomes);
            }
            else if ( type == "Discount")
            {
                double costs = 5.00; 
                double incomes = (double)area * costs;
                Console.WriteLine("{0:00.00} leva", incomes);
            }
            }
        
    }
}
