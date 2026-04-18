
// File: CompoundInterest.cs
using System;

class CompoundInterest
{
    static void Main()
    {
        Console.Write("Enter Principal Amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest (% per year): ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        double time = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Number of Times Interest Compounded per Year (e.g. 1=Yearly, 2=Half-Yearly, 4=Quarterly, 12=Monthly): ");
        int n = Convert.ToInt32(Console.ReadLine());

        double amount = principal * Math.Pow((1 + rate / (n * 100)), n * time);
        double compoundInterest = amount - principal;

        Console.WriteLine("\n========== Result ==========");
        Console.WriteLine($"Principal Amount        : ₹{principal}");
        Console.WriteLine($"Rate of Interest        : {rate}%");
        Console.WriteLine($"Time                    : {time} year(s)");
        Console.WriteLine($"Compounded              : {n} time(s) per year");
        Console.WriteLine($"Compound Interest (CI)  : ₹{compoundInterest:F2}");
        Console.WriteLine($"Total Amount            : ₹{amount:F2}");
        Console.WriteLine("============================");
    }
}