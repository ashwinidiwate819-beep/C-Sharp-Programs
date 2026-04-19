using System;

class TupleDemo
{
    static void Main()
    {
        var student = (Id: 29, Name: "Karan", Marks: 85);

        Console.WriteLine("ID: " + student.Id);
        Console.WriteLine("Name: " + student.Name);
        Console.WriteLine("Marks: " + student.Marks);
    }
}
