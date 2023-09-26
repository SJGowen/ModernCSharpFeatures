namespace ModernCSharpFeatures;

public class CastUsingIsNewFeature
{

    public class Shape {}

    public class Square : Shape
    {
        public int SideLength;
    }

    public class Circle : Shape
    {
        public int Radius;
    }

    public static double Area(Shape shape)
    {
        if (shape is Square square) return square.SideLength * square.SideLength;
        if (shape is Circle circle) return circle.Radius * circle.Radius * Math.PI;

        throw new InvalidOperationException("Invalid Shape");
    }

    public CastUsingIsNewFeature()
    {
        var square = new Square { SideLength = 10 };
        var circle = new Circle { Radius = 10 };

        Console.WriteLine($"Square area = {Area(square)}");
        Console.WriteLine($"Circle area = {Area(circle)}");
    }
}
