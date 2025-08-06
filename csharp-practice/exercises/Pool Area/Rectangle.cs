namespace csharp_practice.exercises.Pool_Area;

public class Rectangle
{
    private double _width;
    private double _length;

    public Rectangle(double width, double length)
    {
        _width = width >= 0 ? width : 0;
        _length = length >= 0 ? length : 0;
    }

    public double GetWidth() => _width;
    public double GetLength() => _length;
    public double GetArea() => _width * _length;
}