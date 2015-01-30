using System;
    class Program
    {
        static void Main(string[] args)
        {
            //has a total of 4 vowels: three times ‘A’ and one time ‘I’ and their sum is: 3 * 65 + 1 * 73 = 268.

            string movieLine = Console.ReadLine();
            string movieLineUpper = movieLine.ToUpper();
            int length = movieLineUpper.Length;
            char[] line = new char[length];
            int vowel = 0;
            int volewCounter = 0;
            int sum = 0;
            for (int i = 0; i < movieLineUpper.Length; i++)
            {

                line[i] = movieLineUpper[i];

                if (movieLineUpper[i] == 'A')
                {
                    vowel = 65 ;
                    volewCounter++;
                    sum = vowel + sum;
                }
                else if (movieLineUpper[i] == 'E')
                {
                    vowel = 69;
                    volewCounter++;
                    sum = vowel +sum;
                }
                else if (movieLineUpper[i] == 'I')
                {
                    vowel = 73;
                    volewCounter++;
                    sum = vowel + sum;
                }
                else if (movieLineUpper[i] == 'O')
                {
                    vowel = 79;
                    volewCounter++;
                    sum = vowel + sum;
                }
                else if (movieLineUpper[i] == 'U')
                {
                    vowel = 85;
                    volewCounter++;
                    sum = vowel + sum;
                }
                
             }
            Console.WriteLine(volewCounter);
            Console.WriteLine(sum);

        }
    }
