using System;
using System.Collections.Generic;
using System.Text;

public class Citizen:IPerson
{
    private string name;
    private int age;

    public string Name { get { return this.name; } private set { name = value; }}

    public int Age { get { return this.age; } private set { age = value; } }

    public Citizen(string name, int age)
    {
        this.name = Name;
        this.age = Age;

    }
    
}