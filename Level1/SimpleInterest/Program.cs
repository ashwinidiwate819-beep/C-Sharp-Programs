// File: SimpleInterest.cs
using System;

class SimpleInterest
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest (% per year): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        double simpleInterest = (principal * rate * time) / 100;
        double totalAmount = principal + simpleInterest;

        Console.WriteLine("\n========== Result ==========");
        Console.WriteLine($"Principal Amount : {principal}");
        Console.WriteLine($"Rate of Interest : {rate}%");
        Console.WriteLine($"Time             : {time} year(s)");
        Console.WriteLine($"Simple Interest  : {simpleInterest}");
        Console.WriteLine($"Total Amount     : {totalAmount}");
        Console.WriteLine("============================");
    }
}