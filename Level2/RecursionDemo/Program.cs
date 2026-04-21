using System;

class RecursionDemo
{
    static void PrintNumbers(int n)
    {
        if (n == 0)
            return;

        Console.WriteLine(n);
        PrintNumbers(n - 1);
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        PrintNumbers(num);
    }
}
