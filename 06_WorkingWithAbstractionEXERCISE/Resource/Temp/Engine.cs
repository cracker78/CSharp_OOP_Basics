using System;
using System.Collections.Generic;
using System.Text;

public  class Engine
{
    public string model;
    public string power;
    public string displacement;
    public string efficiency;

    public Engine(string model, string power= "n/a", string displacement= "n/a", string efficiency= "n/a")
    {
        this.model = model;
        this.power = power;
        this.displacement = displacement;
        this.efficiency = efficiency;

    }
}

