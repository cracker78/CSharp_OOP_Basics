using System;
using System.Linq;


class Temp
{
    static void Main()
    {
        int inputEngine = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputEngine; i++)
        {
            Engine input = new Engine();
            string[] tokens = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }

        int inputCar = int.Parse(Console.ReadLine());

        for (int i = 0; i < inputCar; i++)
        {
            Car car = new Car();

            string[] tokens = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).ToArray();

            
        }
    }
}
