using System;

class ConstReadonlyDemo
{
    // Constant variable
    const double PI = 3.14159;

    // Readonly variable
    readonly int rollNo;

    // Constructor
    ConstReadonlyDemo(int r)
    {
        rollNo = r;   // readonly can be assigned in constructor
    }

    static void Main()
    {
        ConstReadonlyDemo obj = new ConstReadonlyDemo(101);

        Console.WriteLine("Constant Value:");
        Console.WriteLine("PI = " + PI);

        Console.WriteLine();

        Console.WriteLine("Readonly Value:");
        Console.WriteLine("Roll Number = " + obj.rollNo);
    }
}
