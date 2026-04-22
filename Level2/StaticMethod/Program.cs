using System;

class MathOperations
{
    public static void Square(int num)
    {
        Console.WriteLine("Square = " + (num * num));
    }
}

class StaticMethodUserInput
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        MathOperations.Square(num); // static method call
    }
}
