namespace csharp_practice.exercises;

public class EqualSumChecker
{
    public static Boolean HasEqualSum(int firstNumber, int secondNumber, int thirdNumber)
    {
        return firstNumber + secondNumber == thirdNumber;
    }

    public static void Playground()
    { 
        Console.WriteLine(HasEqualSum(1, 1, 1));  
        Console.WriteLine(HasEqualSum(1, 1, 2));
        Console.WriteLine(HasEqualSum(1, -1, 0));  
    }
}