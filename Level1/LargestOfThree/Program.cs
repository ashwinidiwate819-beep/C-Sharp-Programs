// File: LargestOfThree.cs
using System;

class LargestOfThree
{
    static void Main()
    {
        Console.Write("Enter First Number  : ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Second Number : ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Third Number  : ");
        double num3 = Convert.ToDouble(Console.ReadLine());

        double largest;

        if (num1 >= num2 && num1 >= num3)
            largest = num1;
        else if (num2 >= num1 && num2 >= num3)
            largest = num2;
        else
            largest = num3;

        Console.WriteLine("\n========== Result ==========");
        Console.WriteLine($"First Number       : {num1}");
        Console.WriteLine($"Second Number      : {num2}");
        Console.WriteLine($"Third Number       : {num3}");
        Console.WriteLine($"Largest Number     : {largest}");
        Console.WriteLine("============================");
    }
} 