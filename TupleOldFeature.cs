namespace ModernCSharpFeatures;

public class TupleOldFeature 
{

    public static void Calculate(int x, int y, out int sum, out int product)
    {
        sum = x + y;
        product = x * y;
    }
    
    public TupleOldFeature()
    {
        const int x = 2;
        const int y = 3;        

        Calculate(x, y, out int sum, out int product);

        Console.WriteLine($"{x} + {y} = {sum}");
        Console.WriteLine($"{x} * {y} = {product}");
    }
}
