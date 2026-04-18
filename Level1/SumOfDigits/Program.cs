using System;

class SumOfDigits
{
    static void Main()
    {
        int number, sum = 0, digit;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        while (number != 0)
        {
            digit = number % 10;
            sum += digit;
            number /= 10;
        }

        Console.WriteLine("Sum of digits = " + sum);
    }
}
