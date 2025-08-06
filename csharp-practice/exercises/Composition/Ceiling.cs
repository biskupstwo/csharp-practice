namespace csharp_practice.exercises.Composition;

public class Ceiling
{
    private int _height;
    private int _paintedColor;

    public Ceiling(int height, int paintedColor)
    {
        _height = height;
        _paintedColor = paintedColor;
    }

    public int GetHeight() => _height;
    public int GetPaintedColor() => _paintedColor;
}