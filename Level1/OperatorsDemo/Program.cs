using System;

class OperatorsDemo
{
    static void Main()
    {
        int a = 10, b = 5;

        // Arithmetic Operators
        Console.WriteLine("Arithmetic Operators:");
        Console.WriteLine("a + b = " + (a + b));
        Console.WriteLine("a - b = " + (a - b));
        Console.WriteLine("a * b = " + (a * b));
        Console.WriteLine("a / b = " + (a / b));
        Console.WriteLine("a % b = " + (a % b));

        Console.WriteLine();

        // Relational Operators
        Console.WriteLine("Relational Operators:");
        Console.WriteLine("a > b : " + (a > b));
        Console.WriteLine("a < b : " + (a < b));
        Console.WriteLine("a == b : " + (a == b));
        Console.WriteLine("a != b : " + (a != b));

        Console.WriteLine();

        // Logical Operators
        Console.WriteLine("Logical Operators:");
        Console.WriteLine("(a > b && b > 0) : " + (a > b && b > 0));
        Console.WriteLine("(a > b || b > 10) : " + (a > b || b > 10));
        Console.WriteLine("!(a > b) : " + !(a > b));

        Console.WriteLine();

        // Assignment Operators
        Console.WriteLine("Assignment Operators:");
        int c = a;
        c += b;
        Console.WriteLine("c += b : " + c);
        c -= b;
        Console.WriteLine("c -= b : " + c);

        Console.WriteLine();

        // Unary Operators
        Console.WriteLine("Unary Operators:");
        int x = 5;
        Console.WriteLine("x = " + x);
        Console.WriteLine("++x = " + (++x));
        Console.WriteLine("--x = " + (--x));
    }
}
