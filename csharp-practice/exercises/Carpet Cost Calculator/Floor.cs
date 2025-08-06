namespace csharp_practice.exercises.Carpet_Cost_Calculator;

public class Floor
{
    private double _width;
    private double _length;

    public Floor(double width, double length)
    {
        _width = width >= 0 ? width : 0;
        _length = length >= 0 ? length : 0;
    }

    public double GetArea() => _width * _length;
}