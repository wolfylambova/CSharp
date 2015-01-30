using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
           
            #region TribonacciDealing

            BigInteger firstTribonacci = BigInteger.Parse(Console.ReadLine());
            BigInteger secondTribonacci = BigInteger.Parse(Console.ReadLine());
            BigInteger thirdTribonacci = BigInteger.Parse(Console.ReadLine());
                      
                         BigInteger firstSpiralMemb = BigInteger.Parse(Console.ReadLine());
                         int stepSpiral = int.Parse(Console.ReadLine());
          
            List<BigInteger> TribonacciList = new List<BigInteger>();
            TribonacciList.Add(firstTribonacci);
            TribonacciList.Add(secondTribonacci);
            TribonacciList.Add(thirdTribonacci);

            BigInteger fourthTribonacci = firstTribonacci + secondTribonacci + thirdTribonacci;
            TribonacciList.Add(fourthTribonacci);
            BigInteger memberTribonacci = 0;
            BigInteger a = 0;
            a = secondTribonacci;
            BigInteger b = 0;
            b = thirdTribonacci;
            BigInteger c = 0;
            c = fourthTribonacci;
            for (int i = (int)0; i <= 100; i++)
            {
                memberTribonacci = a + b + c;
                TribonacciList.Add(memberTribonacci);
                a = b;
                b = c;
                c = memberTribonacci;
            } 
           
            #endregion

            #region SpiralNumbers

            List<BigInteger> spiralMembers = new List<BigInteger>();
            spiralMembers.Add(firstSpiralMemb);

            BigInteger secondSpiralMemb = firstSpiralMemb + stepSpiral;
            spiralMembers.Add(secondSpiralMemb);

            BigInteger thirdSpitalMemb = secondSpiralMemb + stepSpiral;
            spiralMembers.Add(thirdSpitalMemb);

            BigInteger third = 0;
            third = thirdSpitalMemb;

            BigInteger fourthSpiralMemb = 0;
            BigInteger nextSpiralMemb = 0;
        
            if (stepSpiral == 1)
            {
                for (int i = 2 ; i < 100; i+=2)
                {
                    for (int j = i; j < 100; j+=2)
                    {
                    fourthSpiralMemb = third + i * stepSpiral;
                    spiralMembers.Add(fourthSpiralMemb);
                    third = fourthSpiralMemb;
                
                    nextSpiralMemb = third + j * stepSpiral;
                    spiralMembers.Add(nextSpiralMemb);
                    third = nextSpiralMemb;
                    break;
                    }
                }
            }
            else
	        {
             for (int i = 2 ; i < 100; i++)
                {
                  for (int j = i; j < 100; j++)
                  {
                    fourthSpiralMemb = third + i * stepSpiral;
                    spiralMembers.Add(fourthSpiralMemb);
                    third = fourthSpiralMemb;
                
                    nextSpiralMemb = third + j * stepSpiral;
                    spiralMembers.Add(nextSpiralMemb);
                    third = nextSpiralMemb;
                    break;
                 }
                }
	        }
            #endregion

            #region SearchForTheFirstMatch
            BigInteger matchNumb = 0;
           
            
            var matchList = spiralMembers.Intersect(TribonacciList);
            List<BigInteger> matches = new List<BigInteger>();

            foreach (var match in matchList)
            {
                matches.Add(match);
            }
            bool isEmpty = !matches.Any();
            if (!isEmpty)
            {
                BigInteger minMatch = (BigInteger)matchList.Min();
                Console.WriteLine(minMatch);
            }
            if (isEmpty)
            {
                Console.WriteLine("No.");
            }
            #endregion
        }
    }
