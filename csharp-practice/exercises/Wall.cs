namespace csharp_practice.exercises;

public class Wall
{
    private double _width;
    private double _height;

    public Wall(){}

    public Wall(double width, double height)
    {
        _width = width >= 0 ? width : 0;
        _height = height >= 0 ? height : 0;
    }

    public double GetWidth() => _width;
    public double GetHeight() => _height;
    public void SetWidth(double width) => _width = width >= 0 ? width : 0;
    public void SetHeight(double height) => _height = height >= 0 ? height : 0;

    public double GetArea() => _width * _height;
}