// See https://aka.ms/new-console-template for more information
using System;



class Rectangle
{
    private double side1;
    private double side2;

    public Rectangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculateArea()
    {
        return side1 * side2;
    }

    public double CalculatePerimeter()
    {
        return 2 * (side1 + side2);
    }

    public double Area
    {
        get { return CalculateArea(); }
    }

    public double Perimeter
    {
        get { return CalculatePerimeter(); }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введіть довжину першої сторони прямокутника: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть довжину другої сторони прямокутника: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Rectangle rectangle = new Rectangle(side1, side2);

        Console.WriteLine($"Площа прямокутника: {rectangle.Area}");
        Console.WriteLine($"Периметр прямокутника: {rectangle.Perimeter}");

        Console.ReadLine();
    }
}




class Point
{
    public double X { get; }
    public double Y { get; }
    public string Name { get; }

    public Point(double x, double y, string name)
    {
        X = x;
        Y = y;
        Name = name;
    }
}

class Figure
{
    private Point[] points;

    public Figure(Point p1, Point p2, Point p3)
    {
        points = new Point[] { p1, p2, p3 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4)
    {
        points = new Point[] { p1, p2, p3, p4 };
    }

    public Figure(Point p1, Point p2, Point p3, Point p4, Point p5)
    {
        points = new Point[] { p1, p2, p3, p4, p5 };
    }

    public double GetSideLength(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
    }

    public void CalculatePerimeter()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            int nextIndex = (i + 1) % points.Length;
            perimeter += GetSideLength(points[i], points[nextIndex]);
        }

        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}

class MyProgram
//2
{
    static void Main1(string[] args)
    {
        Point p1 = new Point(0, 0, "A");
        Point p2 = new Point(4, 0, "B");
        Point p3 = new Point(4, 3, "C");

        Figure triangle = new Figure(p1, p2, p3);
        triangle.CalculatePerimeter();

        Point p4 = new Point(0, 0, "A");
        Point p5 = new Point(4, 0, "B");
        Point p6 = new Point(4, 3, "C");
        Point p7 = new Point(0, 3, "D");

        Figure quadrilateral = new Figure(p4, p5, p6, p7);
        quadrilateral.CalculatePerimeter();

        Console.ReadLine();
    }
}


