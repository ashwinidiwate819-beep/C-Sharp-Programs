using System;

class ArrayToMethod
{
    static void DisplayArray(int[] arr)
    {
        Console.WriteLine("Array elements:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }

    static void Main()
    {
        Console.Write("Enter array size: ");
        int size = int.Parse(Console.ReadLine());

        int[] arr = new int[size];

        for (int i = 0; i < size; i++)
        {
            Console.Write("Enter element " + (i + 1) + ": ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        DisplayArray(arr);
    }
}
