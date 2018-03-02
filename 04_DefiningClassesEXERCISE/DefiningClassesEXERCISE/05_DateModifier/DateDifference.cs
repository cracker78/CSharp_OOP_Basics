using System;
using System.Globalization;

public class DateDifference
{
    public static int CalculateDateDifference(string startDate, string endDate)
    {
        var difference = DateTime.Parse(startDate) - DateTime.Parse(endDate);
        return Math.Abs(difference.Days);
    }
}
