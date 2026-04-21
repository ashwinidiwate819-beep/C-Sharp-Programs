using System;

class LargestSmallestArray
{
    static void Main()
    {
        int[] arr = { 25, 10, 45, 5, 30 };

        int largest = arr[0];
        int smallest = arr[0];

        foreach (int num in arr)
        {
            if (num > largest)
                largest = num;

            if (num < smallest)
                smallest = num;
        }

        Console.WriteLine("Largest = " + largest);
        Console.WriteLine("Smallest = " + smallest);
    }
}
