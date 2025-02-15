namespace csharp_practice.exercises;

public class NumberPalindrome
{
    public static bool IsPalindrome(int number)
    {
        int reversedNumber = 0;
        bool isNegative = number < 0;
        int temporaryNumber = isNegative ? number * -1 : number;
        while (temporaryNumber != 0)
        {
            reversedNumber = reversedNumber*10 + (temporaryNumber % 10);
            temporaryNumber /= 10;
        }
        if (isNegative) reversedNumber *= -1;
        Console.WriteLine(reversedNumber);
        return number == reversedNumber;
    }

    public static void Playground()
    {
        Console.WriteLine(IsPalindrome(-1221));  
        Console.WriteLine(IsPalindrome(707));   
        Console.WriteLine(IsPalindrome(11212));
    }
}