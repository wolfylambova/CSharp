using System;

class Diamond
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        if (n >= 3 && n <= 27)
        {
            int middleDots = ((n - 1) / 2) - 1;
            int width = n * 2 + 1;
            int countDots = (width - n) / 2;
            int height = (6 + (((n - 3) / 2) * 3));

            char star = '*';
            char dot = '.';

            // първа част 
            for (int j = 0; j <= width && countDots >= 1; j++)
            {
                int countStars = n;

                // разделяне на звездите за j != 0 
                if (j >= 1)
                {
                    countStars = 1;
                }
                string Dots = new string(dot, countDots);
                string Middle = new string(dot, middleDots);
                string stars = new string(star, countStars);

                // първи ред 
                if (countStars == n)
                    Console.WriteLine("{0}{1}{2}", Dots, stars, Dots);

                // други редове 
                else
                    Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", Dots, stars, Middle, stars, Middle, stars, Dots);

                countDots--;
                middleDots++;
                height--;  // oтброява редовете

            }

            // разделляне със звезди
            string razdelitelniZvezdi = new string(star, width);
            Console.WriteLine(razdelitelniZvezdi);
            height--;

            countDots++;             // връщане на предходните стойности   
            middleDots--;       // 

            //втора част
            for (int i = 0; i < height; i++)
            {

                int countStars = 1;
                string startingDots = new string(dot, countDots);
                string Middle = new string(dot, middleDots);
                string stars = new string(star, countStars);

                if (countDots * 2 == width - 1)
                {

                    Console.WriteLine(startingDots + stars + startingDots);
                    break;
                }

                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}", startingDots, stars, Middle, stars, Middle, stars, startingDots);

                countDots++;
                if (middleDots >= 1)
                {
                    middleDots--;
                }

            }
        }
    }
}