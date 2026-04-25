using System;

struct ValueTypeExample
{
    public int Number;
}

class ReferenceTypeExample
{
    public int Number;
}

class Program
{
    static void Main()
    {
        ValueTypeExample v1 = new ValueTypeExample { Number = 10 };
        ValueTypeExample v2 = v1;
        v2.Number = 20;

        Console.WriteLine("Value Type:");
        Console.WriteLine("v1.Number = " + v1.Number);

        ReferenceTypeExample r1 = new ReferenceTypeExample { Number = 10 };
        ReferenceTypeExample r2 = r1;
        r2.Number = 20;

        Console.WriteLine("Reference Type:");
        Console.WriteLine("r1.Number = " + r1.Number);
    }
}


