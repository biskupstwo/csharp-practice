namespace csharp_practice.exercises;

public class SharedDigit
{
    public static bool HasSharedDigit(int firstNumber, int secondNumber)
    {
        if (firstNumber < 10 || firstNumber > 99 || secondNumber < 10 || secondNumber > 99) return false;
        string firstNumberString = firstNumber.ToString();
        string secondNumberString = secondNumber.ToString();
        bool result = firstNumberString.Contains(secondNumberString[0]) ||
                      firstNumberString.Contains(secondNumberString[1]);
        return result;
    }
}