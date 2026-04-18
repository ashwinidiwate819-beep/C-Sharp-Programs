using System;

class ArmstrongNumber
{
    static void Main()
    {
        int number, originalNumber, remainder, result = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        originalNumber = number;

        while (originalNumber != 0)
        {
            remainder = originalNumber % 10;
            result += remainder * remainder * remainder;
            originalNumber /= 10;
        }

        if (result == number)
            Console.WriteLine(number + " is an Armstrong number.");
        else
            Console.WriteLine(number + " is not an Armstrong number.");
    }
}
