using System;

class OutRefUserInput
{
    static void Add(ref int a)
    {
        a = a + 10;
    }

    static void Multiply(out int b)
    {
        b = 0;
        Console.Write("Enter number for out parameter: ");
        b = int.Parse(Console.ReadLine());
        b = b * 2;
    }

    static void Main()
    {
        Console.Write("Enter number for ref parameter: ");
        int x = int.Parse(Console.ReadLine());

        Add(ref x);
        Console.WriteLine("After ref: " + x);

        int y;
        Multiply(out y);
        Console.WriteLine("After out: " + y);
    }
}
