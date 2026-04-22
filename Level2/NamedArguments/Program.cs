using System;

class NamedArgumentsUserInput
{
    static void StudentDetails(string name, int rollNo, string course)
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Course: " + course);
    }

    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter roll number: ");
        int roll = int.Parse(Console.ReadLine());

        Console.Write("Enter course: ");
        string course = Console.ReadLine();

        // Named arguments (order changed)
        StudentDetails(course: course, rollNo: roll, name: name);
    }
}
