using System;

class ParamsUserInput
{
    static void AddNumbers(params int[] numbers)
    {
        int sum = 0;
        foreach (int n in numbers)
        {
            sum += n;
        }
        Console.WriteLine("Sum = " + sum);
    }

    static void Main()
    {
        Console.Write("Enter how many numbers: ");
        int count = int.Parse(Console.ReadLine());

        int[] nums = new int[count];

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter number " + (i + 1) + ": ");
            nums[i] = int.Parse(Console.ReadLine());
        }

        AddNumbers(nums);
    }
}
