using System;
namespace Problem_9.Play_with_Int__Double_and_String
{
    class PlayME
    {
        static void Main(string[] args)
        { Console.WriteLine("Please, choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int choice = int.Parse(Console.ReadLine());
 
            switch (choice)
            {
                case 1: Console.Write("Please enter a integer: ");  
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine(a + 1);break;
                case 2: Console.Write("Please enter a double: ");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(b + 1.00);  break;
                case 3: Console.Write("Please enter a string: ");
                        string c = Console.ReadLine();
                        Console.WriteLine(c + "*");break;
                default: Console.WriteLine("Not correct choice!"); break;
        }
    }
}
