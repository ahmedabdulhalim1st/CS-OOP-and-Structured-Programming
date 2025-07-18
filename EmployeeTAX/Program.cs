﻿using System;
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
            System.Console.WriteLine(e1.PrintSlip());
        }
        Console.ReadKey();
        return 0;
    }
}
