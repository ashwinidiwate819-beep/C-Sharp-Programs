using System;

class MethodWithParameters
{
    static void Add(int a, int b)
    {
        int sum = a + b;
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        Console.Write("Enter first number: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter second number: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Add(x, y);
    }
}
