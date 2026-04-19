using System;

enum Days { Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday }

class EnumDemo
{
    static void Main()
    {
        Days today = Days.Monday;
        Console.WriteLine("Today is: " + today);
    }
}

