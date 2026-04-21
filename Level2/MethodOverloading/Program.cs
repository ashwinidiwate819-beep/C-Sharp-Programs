using System;

class MethodOverloading
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static double Add(double a, double b)
    {
        return a + b;
    }

    static int Add(int a, int b, int c)
    {
        return a + b + c;
    }

    static void Main()
    {
        Console.WriteLine("Add(int, int): " + Add(10, 20));
        Console.WriteLine("Add(double, double): " + Add(10.5, 20.5));
        Console.WriteLine("Add(int, int, int): " + Add(5, 10, 15));
    }
}
