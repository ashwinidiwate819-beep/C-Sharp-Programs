using System;

class UserDetails
{
    static void Main()
    {
        // Declare variables
        string name, email, phone;
        int age;

        // Input from user
        Console.WriteLine("Enter User Details");

        Console.Write("Enter Name: ");
        name = Console.ReadLine();

        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Email: ");
        email = Console.ReadLine();

        Console.Write("Enter Phone Number: ");
        phone = Console.ReadLine();

        // Display user details
        Console.WriteLine("\n----- User Details -----");
        Console.WriteLine("Name  : " + name);
        Console.WriteLine("Age   : " + age);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Phone : " + phone);

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
