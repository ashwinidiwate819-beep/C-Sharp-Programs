using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string text = "My mobile number is 9876543210";

        string pattern = @"\d{10}";

        Match match = Regex.Match(text, pattern);

        if (match.Success)
            Console.WriteLine("Mobile number found: " + match.Value);
        else
            Console.WriteLine("No mobile number found");
    }
}

