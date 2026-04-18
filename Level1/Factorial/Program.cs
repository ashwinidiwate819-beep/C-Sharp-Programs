
// File: Factorial.cs
using System;

class Factorial
{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("\nFactorial is not defined for Negative Numbers!");
        }
        else
        {
            // Method 1 - Using Loop
            long factorialLoop = 1;
            for (int i = 1; i <= num; i++)
            {
                factorialLoop *= i;
            }

            // Method 2 - Using Recursion
            long factorialRecursion = FindFactorial(num);

            Console.WriteLine("\n========== Result ==========");
            Console.WriteLine($"Number                        : {num}");
            Console.WriteLine($"Factorial (Loop)              : {factorialLoop}");
            Console.WriteLine($"Factorial (Recursion)         : {factorialRecursion}");
            Console.WriteLine("============================");
        }
    }

    // Recursive Method
    static long FindFactorial(int n)
    {
        if (n == 0 || n == 1)
            return 1;
        return n * FindFactorial(n - 1);
    }
}