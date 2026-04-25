using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };

        Span<int> span = numbers;
        ReadOnlySpan<int> readOnlySpan = numbers;

        span[0] = 100; // Modifies original array

        Console.WriteLine("Span values:");
        foreach (var item in span)
            Console.Write(item + " ");

        Console.WriteLine("\nReadOnlySpan values:");
        foreach (var item in readOnlySpan)
            Console.Write(item + " ");
    }
}

