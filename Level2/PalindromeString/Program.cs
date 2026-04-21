using System;

class PalindromeString
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string reverse = "";
        for (int i = str.Length - 1; i >= 0; i--)
        {
            reverse += str[i];
        }

        if (str.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            Console.WriteLine("String is a palindrome.");
        else
            Console.WriteLine("String is not a palindrome.");
    }
}

