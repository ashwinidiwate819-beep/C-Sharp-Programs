
using System;

class PrimeNumbersInRange
{
    static void Main()
    {
        int start, end;
        bool isPrime;

        Console.Write("Enter starting number: ");
        start = int.Parse(Console.ReadLine());

        Console.Write("Enter ending number: ");
        end = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers between " + start + " and " + end + " are:");

        for (int num = start; num <= end; num++)
        {
            if (num <= 1)
                continue;

            isPrime = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                Console.Write(num + " ");
        }
    }
}
