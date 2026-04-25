using System;

class Student
{
    private string[] names = new string[3];

    // Indexer
    public string this[int index]
    {
        get { return names[index]; }
        set { names[index] = value; }
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();

        s[0] = "Ashwini";
        s[1] = "Rahul";
        s[2] = "Sneha";

        Console.WriteLine("Student Names:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(s[i]);
        }
    }
}

