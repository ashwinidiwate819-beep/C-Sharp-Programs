// File: CheckNumber.cs
using System;

class CheckNumber
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        double number = Convert.ToDouble(Console.ReadLine());

        if (number > 0)
            Console.WriteLine($"{number} is a Positive number.");
        else if (number < 0)
            Console.WriteLine($"{number} is a Negative number.");
        else
            Console.WriteLine("The number is Zero.");
    }
}