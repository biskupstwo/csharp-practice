namespace csharp_practice.exercises.Composition;

public class Bed
{
    private string _style;
    private int _pillows;
    private int _height;
    private int _sheets;
    private int _quilt;

    public Bed(string style, int pillows, int height, int sheets, int quilt)
    {
        _style = style;
        _pillows = pillows;
        _height = height;
        _sheets = sheets;
        _quilt = quilt;
    }

    public void Make() => Console.Write("Bed -> Making | ");
    public string GetStyle() => _style;
    public int GetPillows() => _pillows;
    public int GetHeight() => _height;
    public int GetSheets() => _sheets;
    public int GetQuilt() => _quilt;
}