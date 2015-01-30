using System;
namespace Problem_3.Check_for_a_Play_Card
{
    class PlayCard
        {
        static void Main()
        {
            Console.WriteLine("Enter the sign of your card:");
            string card = Console.ReadLine();

            switch (card)
            {
                case "1": Console.WriteLine("YES"); break;
                case "2": Console.WriteLine("YES"); break;
                case "3": Console.WriteLine("YES"); break;
                case "4": Console.WriteLine("YES"); break;
                case "5": Console.WriteLine("YES"); break;
                case "6": Console.WriteLine("YES"); break;
                case "7": Console.WriteLine("YES"); break;
                case "8": Console.WriteLine("YES"); break;
                case "9": Console.WriteLine("YES"); break;
                case "10": Console.WriteLine("YES"); break;
                case "J": Console.WriteLine("YES"); break;
                case "Q": Console.WriteLine("YES"); break;
                case "K": Console.WriteLine("YES"); break;
                case "A": Console.WriteLine("YES"); break;
                default: Console.WriteLine("NO");break;
            }
            
        }
    }
}
