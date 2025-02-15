namespace csharp_practice.exercises;

public class EqualityPrinter
{
    public static void PrintEqual(int firstNumber, int secondNumber, int thirdNumber)
    {
        if (firstNumber < 0 || secondNumber < 0 || thirdNumber < 0)
        {
            Console.WriteLine("Invalid Value");
        }
        else if (firstNumber == secondNumber && firstNumber == thirdNumber)
        {
            Console.WriteLine("All numbers are equal");
        }
        else if (firstNumber != secondNumber && firstNumber != thirdNumber && secondNumber != thirdNumber)
        {
            Console.WriteLine("All numbers are different");
        }
        else{
            Console.WriteLine("Neither all are equal or different");
        }
    }

    public static void Playground()
    {
        PrintEqual(1,1,1);
        PrintEqual(1,1,2);
        PrintEqual(-1,-1,-1);
        PrintEqual(1,2,3);
    }
}