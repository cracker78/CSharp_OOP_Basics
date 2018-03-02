using System;
using System.Collections.Generic;
using System.Text;

public class Car
{

    public string CarModel { get; set; }
    public double FuelConsumption { get; set; }
    public double FuelAmount { get; set; }
    public double Distance { get; set; }


    public Car(string carModel, double fuelAmount, double fuelConsumption)
    {
        this.CarModel = carModel;
        this.FuelAmount = fuelAmount;
        this.FuelConsumption = fuelConsumption;
        this.Distance = 0;
    }

    public bool Drive(double distance)
    {
        double fuelNeeded = distance * this.FuelConsumption;
        if (this.FuelAmount<fuelNeeded)
        {
            return false;
        }

        this.FuelAmount -= fuelNeeded;
        this.Distance += distance;
        return true;

    }

}
