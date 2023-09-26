namespace ModernCSharpFeatures;

public class CastUsingIsOldFeature
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
        var square = shape as Square;
        if (square != null)
        {
            return square.SideLength * square.SideLength;
        }

        var circle = shape as Circle;
        if (circle != null)
        {
            return circle.Radius * circle.Radius * Math.PI;
        }
        
        throw new InvalidOperationException("Invalid Shape");
    }

    public CastUsingIsOldFeature()
    {
        var square = new Square { SideLength = 10 };
        var circle = new Circle { Radius = 10 };

        Console.WriteLine($"Square area = {Area(square)}");
        Console.WriteLine($"Circle area = {Area(circle)}");
    }
}
