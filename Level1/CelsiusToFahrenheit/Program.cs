
using System;

class CelsiusToFahrenheit
{
    static void Main()
    {
        double celsius, fahrenheit;

        Console.Write("Enter temperature in Celsius: ");
        celsius = double.Parse(Console.ReadLine());

        fahrenheit = (celsius * 9 / 5) + 32;

        Console.WriteLine("Temperature in Fahrenheit = " + fahrenheit);
    }
}
