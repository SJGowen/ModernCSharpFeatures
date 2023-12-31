﻿namespace ModernCSharpFeatures;

public class TupleNewFeature 
{

    public static (int Sum, int Product) Calculate(int x, int y)
    {
        return (x + y, x * y);
    }
    
    public TupleNewFeature()
    {
        const int x = 2;
        const int y = 3;        

        var result = Calculate(x, y);

        Console.WriteLine($"{x} + {y} = {result.Sum}");
        Console.WriteLine($"{x} * {y} = {result.Product}");
    }
}
