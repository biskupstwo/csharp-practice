namespace csharp_practice.exercises;

public class LastDigitChecker
{
    public static bool IsValid(int number)
    {
        return number >= 10 && number <= 1000;
    }

    public static bool HasSameLastDigit(int firstNumber, int secondNumber, int thirdNumber)
    {
        if (!IsValid(firstNumber) || !IsValid(secondNumber) || !IsValid(thirdNumber)) return false;
        int firstNumberLastDigit = firstNumber % 10;
        int secondNumberLastDigit = secondNumber % 10;
        int thirdNumberLastDigit = thirdNumber % 10;

        return firstNumberLastDigit == secondNumberLastDigit || secondNumberLastDigit == thirdNumberLastDigit ||
               firstNumberLastDigit == thirdNumberLastDigit;
    }

    public static void Playground()
    {
        Console.WriteLine(IsValid(10));
        Console.WriteLine(IsValid(468));
        Console.WriteLine(IsValid(1051));
        
        Console.WriteLine(HasSameLastDigit(41, 22, 71));
        Console.WriteLine(HasSameLastDigit(23, 32, 42));
        Console.WriteLine(HasSameLastDigit(9, 99, 999));
        
        Console.WriteLine(HasSameLastDigit(19, 99, 999));
    }
}