
using System;

class CountDigits
{
    static void Main()
    {
        int number, count = 0;

        Console.Write("Enter a number: ");
        number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            count = 1;
        }
        else
        {
            while (number != 0)
            {
                count++;
                number /= 10;
            }
        }

        Console.WriteLine("Number of digits = " + count);
    }
}
