using System;

class Program
{
    static void Main()
    {
        string name = "Ashwini";
        int age = 21;
        double marks = 89.456;

        Console.WriteLine("Name: {0}, Age: {1}, Marks: {2:F2}", name, age, marks);
        Console.WriteLine($"Name: {name}, Age: {age}, Marks: {marks:F2}");
    }
}
