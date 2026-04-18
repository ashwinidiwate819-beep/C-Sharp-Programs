

// File: PalindromeNumber.cs
using System;

class PalindromeNumbers

{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        long num = Convert.ToInt64(Console.ReadLine());

        long originalNum = num;
        long reversedNum = 0;
        long remainder;

        // Handle negative numbers
        if (num < 0)
        {
            Console.WriteLine("\n========== Result ==========");
            Console.WriteLine($"Number : {num}");
            Console.WriteLine("Negative Numbers are NOT Palindrome!");
            Console.WriteLine("============================");
            return;
        }

        long tempNum = num;

        // Reverse the Number
        while (tempNum > 0)
        {
            remainder    = tempNum % 10;
            reversedNum  = reversedNum * 10 + remainder;
            tempNum      = tempNum / 10;
        }

        Console.WriteLine("\n========== Result ==========");
        Console.WriteLine($"Original Number  : {originalNum}");
        Console.WriteLine($"Reversed Number  : {reversedNum}");

        // Check Palindrome
        if (originalNum == reversedNum)
            Console.WriteLine($"{originalNum} is a PALINDROME Number ✅");
        else
            Console.WriteLine($"{originalNum} is NOT a Palindrome Number ❌");

        Console.WriteLine("============================");
    }
}