using System;

class NullableDemo
{
    static void Main()
    {
        int? num = null;

        Console.WriteLine("Nullable value: " + num);
        Console.WriteLine("Value or default: " + (num ?? 0));
    }
}
