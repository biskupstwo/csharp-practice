namespace csharp_practice.exercises.Encapsulation;

public class Printer
{
    private int _tonerLevel;
    private int _pagesPrinted;
    private bool _duplex;

    public Printer(int tonerLevel, bool duplex)
    {
        _tonerLevel = tonerLevel > -1 && tonerLevel <= 100 ? tonerLevel : -1;
        _duplex = duplex;
    }

    public int AddToner(int tonerAmount)
    {
        if (tonerAmount <= 0 || tonerAmount > 100) return -1;
        if (_tonerLevel + tonerAmount > 100) return -1;
        _tonerLevel += tonerAmount;
        return _tonerLevel;
    }

    public int PrintPages(int pages)
    {
        if (pages <= 0) return 0;
        if (_duplex) Console.WriteLine("Printing in duplex mode");
        int pagesToPrint = _duplex ? (pages+1) / 2 : pages;
        _pagesPrinted += pagesToPrint;
        return pagesToPrint;
    }

    public int GetPagesPrinted() => _pagesPrinted;
}