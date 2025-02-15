namespace csharp_practice.exercises;

public class FirstAndLastDigitSum
{
    public static int SumFirstAndLastDigit(int number)
    {
        if (number < 0) return -1;
        return (number.ToString()[0] - '0') + (number.ToString()[number.ToString().Length - 1] - '0');
    }

    public static void Playground()
    {
        Console.WriteLine(SumFirstAndLastDigit(252));
        Console.WriteLine(SumFirstAndLastDigit(257));
        Console.WriteLine(SumFirstAndLastDigit(0));
        Console.WriteLine(SumFirstAndLastDigit(5));
        Console.WriteLine(SumFirstAndLastDigit(-10));
    }
}