using System;
using System.Collections.Generic;
using System.Text;

public class Car
{
    public string model;
    public Engine engine;
    public string weight;
    public string color;

    public Car(string model, Engine engine, string weight= "n/a", string color= "n/a")
    {
        this.model = model;
        this.engine = engine;
        this.weight = weight;
        this.color = color;
    }
}

