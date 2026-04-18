
using System;

class CheckPrimeNumber
{
    static void Main()
    {
        int number;
        bool isPrime = true;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number <= 1)
        {
            isPrime = false;
        }
        else
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }

        if (isPrime)
            Console.WriteLine(number + " is a Prime Number.");
        else
            Console.WriteLine(number + " is not a Prime Number.");
    }
}
