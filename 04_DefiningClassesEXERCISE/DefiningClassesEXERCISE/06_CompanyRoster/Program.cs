using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        List<Employee> employees=new List<Employee>();
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            string[] args = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = args[0];
            decimal salary = decimal.Parse(args[1]);
            string position = args[2];
            string department = args[3];

            var employee=new Employee(name, salary, position, department);
             
            if (args.Length==5)
            {
                if (args[4].Contains("@"))
                {
                    string email = args[4];
                    employee.Email = args[4];
                }
                else
                {
                    int age = int.Parse(args[4]);
                    employee.Age = int.Parse(args[4]);
                }


            }
            if (args.Length==6)
            {
                string email = args[4];
                int age = int.Parse(args[5]);
                employee.Email = email;
                employee.Age = age;
            }

            employees.Add(employee);
        }

        var result = employees
            .GroupBy(e => e.Department)
            .Select(e => new {
                Department = e.Key,
                AvgSalary = e.Average(emp => emp.Salary),
                Empls = e.OrderByDescending(emp => emp.Salary)
            })
            .ToList()
            .OrderByDescending(e => e.AvgSalary)
            .FirstOrDefault();

        Console.WriteLine($"Highest Average Salary: {result.Department}");


        foreach (var emo in result.Empls)
        {
            Console.WriteLine($"{emo.Name} {emo.Salary:F2} {emo.Email} {emo.Age}");
        }
    }
}
