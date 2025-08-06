namespace csharp_practice.exercises.Cylinder;

public class Cylinder(double radius, double height) : Circle(radius)
{
    private double _height = height >= 0 ? height : 0;
    public double GetHeight() => _height;
    public double GetVolume() => GetArea() * _height;
}