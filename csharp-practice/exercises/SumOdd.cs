namespace csharp_practice.exercises;

public class SumOddExercise
{
    private static bool IsOdd(int number)
    {
        return number > 0 && number % 2 != 0;
    }

    public static int SumOdd(int start, int end)
    {
        if (start <= 0 || end <= 0 || start > end) return -1;
        int sum = 0;
        
        for (int i = start; i <= end; i++)
        {
            sum += IsOdd(i) ? i : 0;
        }

        return sum;
    }

    public static void Playground()
    {
        Console.WriteLine(SumOdd(1, 100));
        Console.WriteLine(SumOdd(-1, 100));
        Console.WriteLine(SumOdd(100, 100));
        Console.WriteLine(SumOdd(13, 13));
        Console.WriteLine(SumOdd(100, -100));
        Console.WriteLine(SumOdd(100, 1000));
    }
}