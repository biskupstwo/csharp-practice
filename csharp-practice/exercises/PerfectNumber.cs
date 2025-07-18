namespace csharp_practice.exercises;

public class PerfectNumber
{
    /// <summary>
    /// The method must calculate if the number is perfect.
    /// If the number is perfect, the method should return true;
    /// otherwise, it should return false.
    /// </summary>
    /// <param name="number">number to check</param>
    /// <returns>true if the number is perfect, otherwise - false</returns>
    public static bool IsPerfectNumber(int number)
    {
        if (number < 1) return false;
        
        int divisor = 1;
        int sum = 0;
        while (divisor <= number/2)
        {
            if (number % divisor == 0) sum += divisor;
            divisor++;
        } 
        return sum == number;
    }

    public static void Playground()
    {
        Console.WriteLine(IsPerfectNumber(6));
        Console.WriteLine(IsPerfectNumber(28));
        Console.WriteLine(IsPerfectNumber(5));
        Console.WriteLine(IsPerfectNumber(-1));
    }
}