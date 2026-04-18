// File: SwapTwoNumbers.cs
using System;

class SwapTwoNumbers
{
    static void Main()
    {
        Console.Write("Enter First Number  : ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number : ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\n========== Before Swap ==========");
        Console.WriteLine($"First Number  : {num1}");
        Console.WriteLine($"Second Number : {num2}");

        // Swap using temp variable
        double temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("\n========== After Swap ===========");
        Console.WriteLine($"First Number  : {num1}");
        Console.WriteLine($"Second Number : {num2}");
        Console.WriteLine("=================================");
    }
}