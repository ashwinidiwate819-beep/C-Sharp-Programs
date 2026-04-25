using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr1 = { 1, 2, 3, 4, 5 };
        int[] arr2 = { 3, 4, 5, 6, 7 };

        var common = arr1.Intersect(arr2);

        Console.WriteLine("Common elements:");
        foreach (int item in common)
        {
            Console.Write(item + " ");
        }
    }
}

