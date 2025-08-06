namespace csharp_practice.exercises.Cylinder;

public class Circle(double radius)
{
    private double _radius = radius >= 0 ? radius : 0;
    public double GetRadius() => _radius;
    public double GetArea() => _radius*_radius*Math.PI;
}