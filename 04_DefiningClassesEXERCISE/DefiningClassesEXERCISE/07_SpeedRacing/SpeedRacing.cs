using System;
using System.Collections.Generic;
using System.Linq;

public class SpeedRacing
{
    static void Main()
    {
        int numOfCars = int.Parse(Console.ReadLine());

        List<Car> cars=new List<Car>();

        for (int i = 0; i < numOfCars; i++)
        {
            string[] input = Console.ReadLine().Split();

            string carModel = input[0];
            int fuelAmount = int.Parse(input[1]);
            double fuelConsumption = double.Parse(input[2]);
 
            Car car=new Car(carModel, fuelAmount, fuelConsumption);

            cars.Add(car);
        }

        string command;

        while ((command=Console.ReadLine())!="End")
        {
            string[] args = command.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string carModel = args[1];
            int distance = int.Parse(args[2]);

            Car car = cars.Find(c => c.CarModel == carModel);
            bool isMoved = car.Drive(distance);

            if (!isMoved)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.CarModel} {car.FuelAmount:F2} {car.Distance}");
        }
    }
}
