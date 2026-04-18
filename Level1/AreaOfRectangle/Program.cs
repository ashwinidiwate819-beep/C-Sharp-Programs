
using System;

class AreaOfRectangle
{
    static void Main()
    {
        double length, width, area;

        Console.Write("Enter the length of the rectangle: ");
        length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        width = double.Parse(Console.ReadLine());

        area = length * width;

        Console.WriteLine("Area of the rectangle = " + area);
    }
}
