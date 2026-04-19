using System;

class RandomNumber
{
    static void Main()
    {
        Random rnd = new Random();

        Console.WriteLine("Random numbers between 1 and 100:");

        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine(rnd.Next(1, 101));
        }
    }
}
