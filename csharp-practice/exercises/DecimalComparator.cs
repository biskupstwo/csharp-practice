namespace csharp_practice.exercises;

public class DecimalComparator
{
    public static Boolean AreEqualByThreeDecimalPlaces(double firstNumber, double secondNumber)
    {
        int first = (int)(firstNumber * 1000);
        int second = (int)(secondNumber * 1000);
        return first == second;
    }
    
    public static void Playground()
    {
        Console.WriteLine(AreEqualByThreeDecimalPlaces(-3.1756, -3.175));
        Console.WriteLine(AreEqualByThreeDecimalPlaces(3.176, 3.175));
        Console.WriteLine(AreEqualByThreeDecimalPlaces(3.0, 3.0));
        Console.WriteLine(AreEqualByThreeDecimalPlaces(-3.123, 3.123));
    }
}