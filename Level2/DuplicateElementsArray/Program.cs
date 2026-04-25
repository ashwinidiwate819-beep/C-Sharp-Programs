using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 2, 4, 5, 3 };

        var duplicates = arr.GroupBy(x => x)
                            .Where(g => g.Count() > 1)
                            .Select(g => g.Key);

        Console.WriteLine("Duplicate elements:");
        foreach (int item in duplicates)
        {
            Console.Write(item + " ");
        }
    }
}

