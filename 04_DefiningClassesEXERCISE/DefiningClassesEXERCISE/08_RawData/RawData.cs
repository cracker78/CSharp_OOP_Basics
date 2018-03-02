using System;
using System.Collections.Generic;
using System.Linq;

public class RawData
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < num; i++)
        {
            string[] args = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string model = args[0];
            int engineSpeed = int.Parse(args[1]);
            int enginePower = int.Parse(args[2]);
            int cargoWeight = int.Parse(args[3]);
            string cargoType = args[4];
            double tire1Pressure = double.Parse(args[5]);
            int tire1Age = int.Parse(args[6]);
            double tire2Pressure = double.Parse(args[7]);
            int tire2Age = int.Parse(args[8]);
            double tire3Pressure = double.Parse(args[9]);
            int tire3Age = int.Parse(args[10]);
            double tire4Pressure = double.Parse(args[11]);
            int tire4Age = int.Parse(args[12]);

            Engine engine=new Engine(engineSpeed,enginePower);
            Cargo cargo=new Cargo(cargoType, cargoWeight);
            Tire[] tires = new Tire[4]
            {
                new Tire(tire1Pressure, tire1Age),
                new Tire(tire2Pressure, tire2Age),
                new Tire(tire3Pressure, tire3Age),
                new Tire(tire4Pressure, tire4Age)
            };

            Car car=new Car(model, engine, cargo, tires);
            cars.Add(car);
        }

        string command = Console.ReadLine();

        if (command== "fragile")
        {
            cars.Where(c=>c.Cargo.Type== "fragile"&& c.Tires.Any(t => t.Pressure < 1)).ToList().ForEach(c=>Console.WriteLine($"{c.Model}"));
        }
        else if (command== "flamable")
        {
            cars
                .Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                .ToList()
                .ForEach(c => Console.WriteLine($"{c.Model}"));
        }
    }
}
