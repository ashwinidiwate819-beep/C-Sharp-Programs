using System;

class OptionalParameterUserInput
{
    static void DisplayInfo(string name, int age = 18)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }

    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Do you want to enter age? (yes/no): ");
        string choice = Console.ReadLine();

        if (choice.ToLower() == "yes")
        {
            Console.Write("Enter age: ");
            int age = int.Parse(Console.ReadLine());
            DisplayInfo(name, age);
        }
        else
        {
            DisplayInfo(name); // default age used
        }
    }
}
