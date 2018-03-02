using System;
using System.Collections.Generic;
using System.Linq;

class OldestFamilyMember
{
    static void Main()
    {
        Family family=new Family();

        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i < num; i++)
        {
            string[] args = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = args[0];
            int age = int.Parse(args[1]);

            family.AddMember(new Person(name, age));
        }

        Person oldestMember = family.GetOldestMember();

        Console.WriteLine($"{oldestMember.Name} {oldestMember.Age}");
    }
}

