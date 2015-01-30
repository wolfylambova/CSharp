using System;

class RandomizeNumbers
{
    static void Main()
    {
    int last = int.Parse(Console.ReadLine());
    Random random = new Random();

    for (int i = 0; i < last; i++)
    {
        int randN = random.Next(i, last+1);
        Console.Write(randN);
    }
    Console.WriteLine();
    }
}

