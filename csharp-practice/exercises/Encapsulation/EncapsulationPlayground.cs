namespace csharp_practice.exercises.Encapsulation;

public class EncapsulationPlayground
{
    public static void Playground()
    {
        Printer printer = new Printer(50, true);
        Console.WriteLine(printer.AddToner(50));
        Console.WriteLine("initial page count = " +printer.GetPagesPrinted());
        int pagesPrinted = printer.PrintPages(4);
        Console.WriteLine("Pages printed was " + pagesPrinted +" new total print count for printer = " +printer.GetPagesPrinted());
        pagesPrinted = printer.PrintPages(2);
        Console.WriteLine("Pages printed was " + pagesPrinted +" new total print count for printer = " +printer.GetPagesPrinted());

    }
}