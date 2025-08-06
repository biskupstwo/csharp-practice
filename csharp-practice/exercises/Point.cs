namespace csharp_practice.exercises;

public struct Point
{
    private int _x;
    private int _y;
    
    public Point(int x, int y)
    {
        _x = x;
        _y = y;
    }

    public int GetX() => _x;
    public int GetY() => _y;
    public void SetX(int x) => _x = x;
    public void SetY(int y) => _y = y;

    public double Distance()
    {
        int xDistance = (0 - _x)*(0 - _x);
        int yDistance = (0 - _y)*(0 - _y);
        return Math.Sqrt(xDistance + yDistance);
    }

    public double Distance(int xb, int yb)
    {
        int xDistance = (xb - _x)*(xb - _x);
        int yDistance = (yb - _y)*(yb - _y);
        return Math.Sqrt(xDistance + yDistance);
    }
    
    public double Distance(Point point)
    {
        int xDistance = (point._x - _x)*(point._x - _x);
        int yDistance = (point._y - _y)*(point._y - _y);
        return Math.Sqrt(xDistance + yDistance);
    }
}