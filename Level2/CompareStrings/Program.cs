using System;

class CompareStrings
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string str1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string str2 = Console.ReadLine();

        if (string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("Strings are equal.");
        }
        else
        {
            Console.WriteLine("Strings are not equal.");
        }
    }
}
