using System;
using System.Linq;

public class DateModifier
{
    public static void Main()
    {

        string startData = Console.ReadLine();

        string endData = Console.ReadLine();

        Console.WriteLine(DateDifference.CalculateDateDifference(startData, endData));


    }
}
