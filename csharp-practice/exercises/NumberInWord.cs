namespace csharp_practice.exercises;

public class NumberInWord
{
    public static void PrintNumberInWord(int number)
    {
        switch (number)
        {
            case 0:
                Console.WriteLine("ZERO");
                break;
            case 1:
                Console.WriteLine("ONE");
                break;
            case 2:
                Console.WriteLine("TWO");
                break;
            case 3:
                Console.WriteLine("THREE");
                break;
            case 4:
                Console.WriteLine("FOUR");
                break;
            case 5:
                Console.WriteLine("FIVE");
                break;
            case 6:
                Console.WriteLine("SIX");
                break;
            case 7:
                Console.WriteLine("SEVEN");
                break;
            case 8:
                Console.WriteLine("EIGHT");
                break;
            case 9:
                Console.WriteLine("NINE");
                break;
            default:
                Console.WriteLine("OTHER");
                break;                    
        }
    }
}