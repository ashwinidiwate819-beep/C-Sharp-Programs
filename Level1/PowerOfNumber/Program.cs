using System;

class PowerOfNumber
{
    static void Main()
    {
        int baseNum, power, result = 1;

        Console.Write("Enter base number: ");
        baseNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter power: ");
        power = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= power; i++)
        {
            result *= baseNum;
        }

        Console.WriteLine("Result = " + result);
    }
}
