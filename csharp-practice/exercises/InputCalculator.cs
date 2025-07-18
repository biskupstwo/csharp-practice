namespace csharp_practice.exercises;

public class InputCalculator
{
    public static void InputThenPrintSumAndAverage()
    {
        int sum = 0;
        int count = 0;
        while (true)
        {
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                sum += number;
                count++;
            }
            else
            {
                break;
            }
        }
        int avg = count != 0 ? sum / count : 0;
        Console.WriteLine($"SUM = {sum} AVG = {avg}");
    }

    public static void Playground()
    {
        InputThenPrintSumAndAverage();
    }
}