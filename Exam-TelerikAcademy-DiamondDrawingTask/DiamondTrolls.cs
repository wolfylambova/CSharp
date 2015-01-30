using System;
using System.Numerics;
    class Program
    {
        static void Main()
        {
//....*******.... i=0 N=7
//...*...*...*... i=1
//..*....*....*.. i=2
//.*.....*.....*. i=3
            
            //int N = 7;
            int N = int.Parse(Console.ReadLine());
            int width =  N*2 + 1;
            int height = 6+((N-3)/2)*3;
            int dot = 3;
            int dotMiddlePad2 = Math.Abs(N-2);
            for (int i = 0; i <= N/2; i++)
			{ 
                if (i==0)
	            { 
		            string dotPad = new string('.',(width-N)/2);
                    string middleStars = new string('*',N);
                    Console.WriteLine(dotPad+middleStars+dotPad);
  	            }
                if (i == N / 2)
                {
                    string line = new string('*', width);
                    Console.WriteLine(line);
                }
                else
                {
                    string dotPad = new string('.', dot);
                    string middleStars = new string('*', 1);
                    string dotPadMiddle = new string('.', dotMiddlePad2);
                    Console.Write(dotPad + middleStars + dotPadMiddle + middleStars + dotPadMiddle + middleStars + dotPad);
                    Console.WriteLine();
                    dot--;
                    dotMiddlePad2++;
                }
			}
//.*.....*.....*. i=5 
//..*....*....*.. i=6
//...*...*...*... i=7
//....*..*..*.... i=8
//.....*.*.*..... i=9
//......***...... i=10
//.......*....... i=11
            int dot2 = 1;
            int dotMiddlePad22 =  Math.Abs(N-2);
            
            for (int i = N/2+1; i <= height; i++)
            {
                if (i==(height-1))
                {
                    string LastButOnePad = new string('.', N-1);
                    string LastButOneStars = new string('*', 3);
                    Console.WriteLine( LastButOnePad + LastButOneStars + LastButOnePad);
                }
                else if (i == height)
                {
                    string LastdotPad = new string('.', N);
                    string LastStars = new string('*', 1);
                    Console.WriteLine(LastdotPad + LastStars + LastdotPad);
                }
                else
                {
                    string dotPad = new string('.', dot2);
                    string middleStars = new string('*', 1);
                    string dotPadMiddle = new string('.', dotMiddlePad22);
                    Console.Write(dotPad + middleStars + dotPadMiddle + middleStars + dotPadMiddle + middleStars + dotPad);
                    Console.WriteLine();
                    dot2++;
                    dotMiddlePad22--;
                }
            }

        }
    }
