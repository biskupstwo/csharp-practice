namespace csharp_practice.exercises;

public class AreaCalculator
{
    public static double Area(double radius)
    {
        return radius >= 0 ? Math.PI*radius*radius : -1;
    }

    public static double Area(double x, double y)
    {
        return x >= 0 && y >= 0 ? x * y : -1;
    }

    public static void Playground()
    {
        Console.WriteLine(Area(5.0));
        Console.WriteLine(Area(-1));
        Console.WriteLine(Area(5.0, 4.0));
        Console.WriteLine(Area(-1.0, 4.0));
    }
}