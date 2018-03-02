using System;
using System.Collections.Generic;
using System.Linq;

public class OpinionPoll
{
    static void Main()
    {
        List<Person> people=new List<Person>();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string name = tokens[0];
            int age = int.Parse(tokens[1]);

            Person person=new Person(name, age);
            people.Add(person);
        }

        var sorted = people.Where(a => a.Age > 30).OrderBy(a => a.Name).ToList();

        foreach (var mem in sorted)
        {
            Console.WriteLine($"{mem.Name} - {mem.Age}");
        }
    }
}

