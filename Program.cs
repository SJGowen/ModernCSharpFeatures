namespace ModernCSharpFeatures;

public class Program
{
    public static void Calculate(int x, int y, out int sum, out int product)
    {
        sum = x + y;
        product = x * y;
    }

    public static void Main(string[] args)
    {
        const int x = 2;
        const int y = 3;        

        Calculate(x, y, out int sum, out int product);

        System.Console.WriteLine($"{x} + {y} = {sum}");
        System.Console.WriteLine($"{x} * {y} = {product}");
    }
}
