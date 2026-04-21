using System;

class ReadDisplayArray
{
    static void Main()
    {
        int[] arr = new int[5];

        Console.WriteLine("Enter 5 elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Array elements are:");
        foreach (int item in arr)
        {
            Console.Write(item + " ");
        }
    }
}
