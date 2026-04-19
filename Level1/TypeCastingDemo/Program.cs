using System;

class TypeCastingDemo
{
    static void Main()
    {
        // Implicit Type Casting (Smaller → Larger)
        int intValue = 50;
        double doubleValue = intValue;

        Console.WriteLine("Implicit Type Casting:");
        Console.WriteLine("Int value: " + intValue);
        Console.WriteLine("Double value: " + doubleValue);

        Console.WriteLine();

        // Explicit Type Casting (Larger → Smaller)
        double num = 45.75;
        int result = (int)num;

        Console.WriteLine("Explicit Type Casting:");
        Console.WriteLine("Double value: " + num);
        Console.WriteLine("Int value after casting: " + result);
    }
}
