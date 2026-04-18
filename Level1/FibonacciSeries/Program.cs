
// File: FibonacciSeries.cs
using System;

class FibonacciSeries
{
    static void Main()
    {
        Console.Write("Enter the Number of Terms : ");
        int terms = Convert.ToInt32(Console.ReadLine());

        if (terms <= 0)
        {
            Console.WriteLine("\nPlease Enter a Positive Number!");
        }
        else
        {
            Console.WriteLine("\n========== Fibonacci Series ==========");

            // Method 1 - Using Loop
            Console.WriteLine("\n📌 Method 1 - Using Loop:");
            FibonacciLoop(terms);

            // Method 2 - Using Recursion
            Console.WriteLine("\n📌 Method 2 - Using Recursion:");
            FibonacciRecursion(terms);

            Console.WriteLine("\n======================================");
        }
    }

    // Method 1 - Using Loop
    static void FibonacciLoop(int terms)
    {
        long first = 0, second = 1, next;

        Console.Write("Series : ");
        for (int i = 1; i <= terms; i++)
        {
            if (i == 1) { Console.Write(first); continue; }
            if (i == 2) { Console.Write(", " + second); continue; }

            next  = first + second;
            first = second;
            second = next;
            Console.Write(", " + next);
        }
        Console.WriteLine();
    }

    // Method 2 - Using Recursion
    static void FibonacciRecursion(int terms)
    {
        Console.Write("Series : ");
        for (int i = 0; i < terms; i++)
        {
            if (i > 0) Console.Write(", ");
            Console.Write(GetFibonacci(i));
        }
        Console.WriteLine();
    }

    static long GetFibonacci(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;
        return GetFibonacci(n - 1) + GetFibonacci(n - 2);
    }
}