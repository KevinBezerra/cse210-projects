using System;

class Program
{
    static void Main(string[] args)
    {
     List<Shape> shapes = new List<Shape>();

        Square s1 = new Square("Red", 5);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Orange", 6, 7);
        shapes.Add(s2);

        Circle s3 = new Circle("Yellow", 8);
        shapes.Add(s3);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}, Area: {shape.GetArea():F2}");
        }
    }
}