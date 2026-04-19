using System;

class DoWhileLoopDemo
{
    static void Main()
    {
        int i = 1;

        Console.WriteLine("Numbers from 1 to 5:");

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= 5);
    }
}
