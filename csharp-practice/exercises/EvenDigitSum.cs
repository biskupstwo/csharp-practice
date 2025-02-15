namespace csharp_practice.exercises;

public class EvenDigitSum
{
    public static int GetEvenDigitSum(int number)
    {
        if (number < 0) return -1;
        int sum = 0;

        while (number > 0)
        {
            int digit = number % 10;
            if (digit % 2 == 0)
            {
                sum += digit;
            }

            number /= 10;
        }

        return sum;
    }

    public static void Playground()
    {
        Console.WriteLine(GetEvenDigitSum(123456789));
        Console.WriteLine(GetEvenDigitSum(252));
        Console.WriteLine(GetEvenDigitSum(-22));
    }
}
