namespace csharp_practice.exercises;

public class GreatestCommonDivisor
{
    public static int GetGreatestCommonDivisor(int firstNumber, int secondNumber)
    {
        if (firstNumber < 10 || secondNumber < 10) return -1;
        
        while (secondNumber != 0)
        {
            int temp = firstNumber % secondNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
        }
        
        return firstNumber;
    }

    public static void Playground()
    {
        Console.WriteLine(GetGreatestCommonDivisor(25,15));
        Console.WriteLine(GetGreatestCommonDivisor(12,30));
        Console.WriteLine(GetGreatestCommonDivisor(9,18));
        Console.WriteLine(GetGreatestCommonDivisor(81,153));
    }
}