using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SubsetSum
    {
        static void Main()
        {
            
            decimal sum = decimal.Parse(Console.ReadLine());
            decimal numbersCounter = decimal.Parse(Console.ReadLine());

            List<decimal> lineNumbers = new List<decimal>();
            
            for (int i = 0; i < numbersCounter; i++)
            {
                decimal num = decimal.Parse(Console.ReadLine());
                lineNumbers.Add(num);
            }
            decimal length = lineNumbers.Count;
            int count = 0;


            if (length==1 && lineNumbers.First() == sum)
            {
                count = 1;
            }
            if (length>1)
            {
                foreach (decimal number in lineNumbers)
                {
                    if (number==sum)
                    {
                        count++;
                    }
                }

                   for (int i = 0; i < lineNumbers.Count-1; i++)
            {
               
                   for (int j = i+1; j < lineNumbers.Count; j++)
                { 
                    if (sum == lineNumbers[i]+lineNumbers[j])
                    {
                        count++;
                    }
                }
            }
            }
         
            Console.WriteLine(count);
        }
    }
