using System;

namespace Cards
{
    class DeckofCards
    {
        static void Main()
        {
            string card = "2";
            for (int i = 2; i <= 14; i++)
            {
                if (i <= 10)
                {
                    Console.Write(i);
                    card = Convert.ToString(i);
                }
                else if (i == 11)
                {
                    card = "J";
                    Console.Write(card);
                }
                else if (i == 12)
                {
                    card = "D";
                    Console.Write(card);
                }
                else if (i == 13)
                {
                    card = "K";
                    Console.Write(card);
                }
                else if (i == 14)
                {
                    card = "A";
                    Console.Write(card);
                }
                for (int face = 1; face <= 4; face++)
                {
                    switch (face)
                    {
                        case 1:
                            Console.Write("♣");
                            Console.Write(card);
                            break;
                        case 2:
                            Console.Write(" ");
                            Console.Write(card);
                            break;
                        case 3:
                            Console.Write(" ");
                            Console.Write(card);
                            break;
                        case 4:
                            Console.WriteLine("");
                            break;

                        //string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
                        //int[] colors = { 3, 4, 5, 6 };

                        //foreach (var card in cards)
                        //{
                        //    foreach (var color in colors)
                        //    {
                        //        Console.Write(card);
                        //        Console.Write((char)color + " ");
                        //    }

                        //    Console.WriteLine();
                    }
                }
            }
        }
    }
}
