using System;

class Program
{
    static void Main(string[] args)
    {
        // create shapes
        Square s1 = new Square("Blue", 7);
        Rectangle r1 = new Rectangle("Green", 5, 8);
        Circle c1 = new Circle("Red", 3);
        
        // create shapes list and add shapes
        List<Shape> shapes = new List<Shape>();
        shapes.Add(s1);
        shapes.Add(r1);
        shapes.Add(c1);

        //iterate through list
        foreach(Shape s in shapes)
        {
            Console.WriteLine(s.GetColor());
            Console.WriteLine(s.GetArea());
        }


    }
}