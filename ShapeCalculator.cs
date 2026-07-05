using System;

class Shape
{
    public virtual void CalculateArea()
    {
        Console.WriteLine("Area cannot be calculated.");
    }
}

class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override void CalculateArea()
    {
        double area = Math.PI * Radius * Radius;
        Console.WriteLine($"Area of Circle = {area:F2}");
    }
}

class Rectangle : Shape
{
    public double Length { get; set; }
    public double Width { get; set; }

    public Rectangle(double length, double width)
    {
        Length = length;
        Width = width;
    }

    public override void CalculateArea()
    {
        double area = Length * Width;
        Console.WriteLine($"Area of Rectangle = {area:F2}");
    }
}

class Triangle : Shape
{
    public double Base { get; set; }
    public double Height { get; set; }

    public Triangle(double b, double h)
    {
        Base = b;
        Height = h;
    }

    public override void CalculateArea()
    {
        double area = 0.5 * Base * Height;
        Console.WriteLine($"Area of Triangle = {area:F2}");
    }
}

class ShapeCalculator
{
    static void Main()
    {
        Shape shape = new Shape();

        shape = new Circle(5);
        shape.CalculateArea();

        shape = new Rectangle(10, 4);
        shape.CalculateArea();

        shape = new Triangle(8, 6);
        shape.CalculateArea();
    }
}
