using System;

class ReplaceSubstring
{
    static void Main()
    {
        Console.Write("Enter the main string: ");
        string mainStr = Console.ReadLine();

        Console.Write("Enter substring to replace: ");
        string oldSub = Console.ReadLine();

        Console.Write("Enter new substring: ");
        string newSub = Console.ReadLine();

        string result = mainStr.Replace(oldSub, newSub);

        Console.WriteLine("Updated string: " + result);
    }
}
