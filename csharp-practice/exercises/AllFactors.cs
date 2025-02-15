namespace csharp_practice.exercises;

public class AllFactors
{
    public static void PrintFactors(int number)
    {
        String output = "";
        if (number < 1) output = "Invalid Value";
        else
        { 
            int i = 1;
            while (i <= number)
            {
                if (number % i == 0)
                {
                    output += $"{i} ";
                }

                i++;
            } 
        }
        Console.WriteLine(output);
    }

    public static void Playground()
    {
        PrintFactors(6);
        PrintFactors(32);
        PrintFactors(10);
        PrintFactors(-1);
        PrintFactors(100);
    }
}