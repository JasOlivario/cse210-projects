using System;
using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();


        Square s = new Square("blue", 13);
        shapes.Add(s);

        Rectangle r = new Rectangle("orange", 14, 3);
        shapes.Add(r);

        Circle c = new Circle("purple", 15);
        shapes.Add(c);



        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }

}