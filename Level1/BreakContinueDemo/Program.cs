using System;

class BreakContinueDemo
{
    static void Main()
    {
        Console.WriteLine("Using continue:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 3)
                continue;

            Console.WriteLine(i);
        }

        Console.WriteLine("\nUsing break:");
        for (int i = 1; i <= 5; i++)
        {
            if (i == 4)
                break;

            Console.WriteLine(i);
        }
    }
}
