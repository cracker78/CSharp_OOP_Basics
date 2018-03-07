using System;
using System.Collections.Generic;
using System.Text;

public class Rectangle
{
    private string id;
    private double width;
    private double height;
    private double coordinateX;
    private double coordinateY;

    public Rectangle(string id, double width, double height, double coordinateX, double coordinateY)
    {
        this.Id = id;
        this.Width = width;
        this.Height = height;
        this.CoordinateX = coordinateX;
        this.CoordinateY = coordinateY;
    }

    public string Id
    {
        get { return id; }
        set { id = value; }
    }

    public double Width
    {
        get { return width; }
        set { width = value; }
    }

    public double Height
    {
        get { return height; }
        set { height = value; }
    }

    public double CoordinateX
    {
        get { return coordinateX; }
        set { coordinateX = value; }
    }
    public double CoordinateY
    {
        get { return coordinateY; }
        set { coordinateY = value; }
    }

    public bool IntersectsRectangle(Rectangle r)
    {
        return this.ContainsRectangleCorner(r) || r.ContainsRectangleCorner(this);
    }

    private bool ContainsRectangleCorner(Rectangle r)
    {
        return this.ContainsPoint(r.coordinateX, r.coordinateY) ||
               this.ContainsPoint(r.coordinateX, r.coordinateY + height) ||
               this.ContainsPoint(r.coordinateX + width, r.coordinateY) ||
               this.ContainsPoint(r.coordinateX + width, r.coordinateY + height);
    }

    private bool ContainsPoint(double x, double y)
    {
        return x >= this.coordinateX && x <= this.coordinateX + width &&
               y >= this.coordinateY && y <= this.coordinateY + height;
    }

}
