﻿using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }
    public string Posotion { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }

    public Employee(string name, decimal salary, string position, string department)
    {
        this.Name = name;
        this.Salary = salary;
        this.Posotion = position;
        this.Department = department;
        this.Email = "n/a";
        this.Age = -1;

    }
}
