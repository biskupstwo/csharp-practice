namespace csharp_practice.exercises;

public class MegaBytesConverter
{
    public static void printMegaBytesAndKilobytes(int kiloBytes)
    {
        string output;
        if (kiloBytes < 0)
        {
            output = "Invalid Value";
        }
        else
        {
            output = $"{kiloBytes} KB = {kiloBytes / 1024} MB and {kiloBytes % 1024} KB";
        }
        Console.WriteLine(output);
    }

    public static void Playground()
    {
        printMegaBytesAndKilobytes(2500);
        printMegaBytesAndKilobytes(-1024);
        printMegaBytesAndKilobytes(5000);
    }
}