
// File: ReverseNumber.cs
using System;

class ReverseNumber
{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        long num = Convert.ToInt64(Console.ReadLine());

        long originalNum  = num;
        long reversedNum  = 0;
        long remainder;

        // Handle negative numbers
        bool isNegative = num < 0;
        if (isNegative)
            num = Math.Abs(num);

        // Reverse Logic
        while (num > 0)
        {
            remainder    = num % 10;
            reversedNum  = reversedNum * 10 + remainder;
            num          = num / 10;
        }

        if (isNegative)
            reversedNum = -reversedNum;

        Console.WriteLine("\n========== Result ==========");
        Console.WriteLine($"Original Number  : {originalNum}");
        Console.WriteLine($"Reversed Number  : {reversedNum}");
        Console.WriteLine("============================");
    }
}