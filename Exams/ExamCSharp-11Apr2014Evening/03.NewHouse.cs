using System;
    class Program
    {
        static void Main()
        { // pokriv = n - 2;  kushta = n;

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n / 2; i++)
            {
                if (i == 0)
                {
                    string dashPad = new string('-', n / 2);
                    Console.WriteLine(dashPad + '*' + dashPad);
                }
                else if (i <= n / 2)
                {
                    string dashPad = new string('-', (n / 2 - i));
                    string middle = new string('*', (n - dashPad.Length * 2));
                    Console.WriteLine(dashPad + middle + dashPad);
                }
            }

                Console.WriteLine(new string('*',n));
               
               for (int i = 0; i < n; i++)
               {
                   int pipe = 1;
                   string pipes = new string ('|', pipe);
                    string starsHouse = new string('*', (n - pipe*2));
                    Console.WriteLine(pipes + starsHouse + pipes);
                   
               }
                    
                
        }
    }
