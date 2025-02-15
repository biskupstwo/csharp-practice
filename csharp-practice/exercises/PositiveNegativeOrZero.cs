namespace csharp_practice.exercises;

public class PositiveNegativeOrZero
{
    public static void CheckNumber(int number)
    {
        if (number > 0)
        {
            Console.WriteLine("positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("zero");
        }
        else
        {
            Console.WriteLine("negative");
        }
    }
}