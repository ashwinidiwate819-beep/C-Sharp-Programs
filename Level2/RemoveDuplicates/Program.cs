using System;
using System.Linq;

class RemoveDuplicates
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 4, 5 };

        int[] uniqueArr = arr.Distinct().ToArray();

        Console.WriteLine("Array after removing duplicates:");
        foreach (int num in uniqueArr)
        {
            Console.Write(num + " ");
        }
    }
}
 