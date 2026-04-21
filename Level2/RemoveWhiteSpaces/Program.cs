using System;

class RemoveWhiteSpaces
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();

        string result = str.Replace(" ", "");

        Console.WriteLine("String without spaces: " + result);
    }
}
