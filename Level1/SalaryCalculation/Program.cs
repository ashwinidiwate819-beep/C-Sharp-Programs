using System;

class SalaryCalculation
{
    static void Main()
    {
        double basic, hra, da, totalSalary;

        Console.Write("Enter Basic Salary: ");
        basic = Convert.ToDouble(Console.ReadLine());

        hra = basic * 0.20;   // 20% HRA
        da = basic * 0.10;    // 10% DA

        totalSalary = basic + hra + da;

        Console.WriteLine("HRA = " + hra);
        Console.WriteLine("DA = " + da);
        Console.WriteLine("Total Salary = " + totalSalary);
    }
}
