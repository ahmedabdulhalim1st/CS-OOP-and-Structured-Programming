using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Formats.Asn1;
using week2;

namespace Week2;

class Program
{
    static int Main()
    {
        // OOP - FIELDS / CONSTANTS
        // - Introduction
        // - OOP Definition
        // - Class VS. Object
        // - Class Modifiers
        // - Access Modifiers
        // - Field - Constant

        // -------------------------------------------
        // const double TAX = 0.03d;
        Employee[] emps = new Employee[1];
        Employee e1 = new();
        System.Console.Write("TAX: ");
        Employee.TAX = Convert.ToDouble(System.Console.ReadLine()) / 100;
        System.Console.Write("First Name: ");
        e1.fName = Console.ReadLine();
        System.Console.Write("Last Name: ");
        e1.lName = Console.ReadLine();
        System.Console.Write("Wage: ");
        e1.wage = Convert.ToDouble(Console.ReadLine());
        System.Console.Write("LoggedHours: ");
        e1.loggedHoures = Convert.ToDouble(Console.ReadLine());

        emps[0] = e1;
        foreach (var emp in emps)
        {
            var salary = (emp.wage * emp.loggedHoures);
            var TAXAmount = (salary * Employee.TAX);
            var netSalary = (salary) - (TAXAmount);
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"First Name   : {emp.fName}");
            System.Console.WriteLine($"Last Name    : {emp.lName}");
            System.Console.WriteLine($"Wage         : {emp.wage}");
            System.Console.WriteLine($"Logged Hours : {emp.loggedHoures}");
            System.Console.WriteLine("----------------------------------------------");
            System.Console.WriteLine($"Salary       : ${salary}");
            System.Console.WriteLine($"TAX Rate     : {Employee.TAX:P0}");
            System.Console.WriteLine($"TAX Amount   : ${TAXAmount}");
            System.Console.WriteLine($"NetSalary    : ${netSalary}");
            System.Console.WriteLine("----------------------------------------------");
        }
        Console.ReadKey();
        return 0;
    }
}
