using System;
using System.Collections.Generic;
using System.Linq;

public class RectangleIntersection
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split().ToArray();
        List<Rectangle> rectangles=new List<Rectangle>();

        int numberOfRectangles = int.Parse(input[0]);
        int intersectionChecks = int.Parse(input[1]);

        for (int i = 0; i < numberOfRectangles; i++)
        {
            string[] args = Console.ReadLine().Split().ToArray();

            string id = args[0];
            double width = double.Parse(args[1]);
            double height = double.Parse(args[2]);
            double coordinateX = double.Parse(args[3]);
            double coordinateY = double.Parse(args[4]);

            var rectangle=new Rectangle(id, width,height,coordinateX,coordinateY);

            rectangles.Add(rectangle);
        }

        for (int i = 0; i < intersectionChecks; i++)
        {
            var args = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var firstRectangle = rectangles.FirstOrDefault(r => r.Id == args[0]);
            var secondRectangle = rectangles.FirstOrDefault(r => r.Id == args[1]);

            if (firstRectangle == null || secondRectangle == null)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine(firstRectangle.IntersectsRectangle(secondRectangle) ? "true" : "false");
            }
        }

    }
}
