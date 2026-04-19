using System;

class AsciiValue
{
    static void Main()
    {
        char ch;

        Console.Write("Enter a character: ");
        ch = Console.ReadLine()[0];

        int asciiValue = (int)ch;

        Console.WriteLine("ASCII value of '" + ch + "' is: " + asciiValue);
    }
}
