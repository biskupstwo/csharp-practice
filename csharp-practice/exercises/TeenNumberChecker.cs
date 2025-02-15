namespace csharp_practice.exercises;

public class TeenNumberChecker
{
    public static Boolean IsTeen(int number)
    {
        return number >= 13 && number <= 19;
    }

    public static Boolean HasTeen(int firstNumber, int secondNumber, int thirdNumber)
    {
        return IsTeen(firstNumber) || IsTeen(secondNumber) || IsTeen(thirdNumber);
    }

    public static void Playground()
    {
        Console.WriteLine(HasTeen(9, 99, 19));
        Console.WriteLine(HasTeen(23, 15, 42));
        Console.WriteLine(HasTeen(22, 23, 24));
        Console.WriteLine(IsTeen(9));
        Console.WriteLine(IsTeen(13));
    }
}