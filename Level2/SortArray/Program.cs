using System;

class SortArray
{
    static void Main()
    {
        int[] arr = { 40, 10, 30, 20, 50 };

        Array.Sort(arr);

        Console.WriteLine("Sorted Array:");
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
    }
}
