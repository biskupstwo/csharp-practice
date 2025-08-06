namespace csharp_practice.exercises.Pool_Area;

public class Cuboid : Rectangle
{
    private double _height;

    public Cuboid(double width, double length, double height) : base(width, length)
    {
        _height = height >= 0 ? height : 0;
    }

    public double GetHeight() => _height;
    public double GetVolume() => GetArea() * _height;
}