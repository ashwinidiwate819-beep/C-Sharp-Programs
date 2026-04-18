
using System;

class AreaOfCircle
{
    static void Main()
    {
        double radius, area;

        Console.Write("Enter the radius of the circle: ");
        radius = double.Parse(Console.ReadLine());

        area = Math.PI * radius * radius;

        Console.WriteLine("Area of the circle = " + area);
    }
}
