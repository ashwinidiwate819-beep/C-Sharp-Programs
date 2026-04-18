
using System;

class GcdLcm
{
    static void Main()
    {
        int num1, num2, gcd, lcm;

        Console.Write("Enter first number: ");
        num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        num2 = int.Parse(Console.ReadLine());

        int a = num1;
        int b = num2;

        // Find GCD using Euclidean Algorithm
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }

        gcd = a;

        // Find LCM
        lcm = (num1 * num2) / gcd;

        Console.WriteLine("GCD = " + gcd);
        Console.WriteLine("LCM = " + lcm);
    }
}
