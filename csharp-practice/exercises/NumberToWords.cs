using System.Text;

namespace csharp_practice.exercises;

public class NumberToWords
{
    private static string GetNumberInWord(int number)
    {
        return number switch
        {
            0 => "Zero",
            1 => "One",
            2 => "Two",
            3 => "Three",
            4 => "Four",
            5 => "Five",
            6 => "Six",
            7 => "Seven",
            8 => "Eight",
            9 => "Nine",
            _ => "Other"
        };

    }
    
    private static int Reverse(int number)
    {
        int numberToReverse = number;
        int reversed = 0;
        if (number < 0) numberToReverse *= -1;
        
        while (numberToReverse > 0)
        {
            reversed = reversed * 10 + numberToReverse % 10;
            numberToReverse /= 10;
        }
        
        if (number < 0) reversed *= -1;
        return reversed;
    }

    private static int GetDigitCount(int number)
    {
        if (number < 0) return -1;
        return number.ToString().Length;
    }
    
    
    public static void ConvertNumberToWords(int number)
    {
        if (number < 0)
        {
            Console.WriteLine("Invalid Value");
            return;
        }

        int reversed = Reverse(number);
        int numberDigitCount = GetDigitCount(number);
        int reversedDigitCount = GetDigitCount(reversed);
        StringBuilder word = new StringBuilder();
        
        while (reversed > 0)
        {
            word.Append($"{GetNumberInWord(reversed % 10)} ");
            reversed /= 10;
        }
        
        if (numberDigitCount > reversedDigitCount)
        {
            int difference = numberDigitCount - reversedDigitCount;
            for (int i = 0; i < difference; i++)
            {
                word.Append($"{GetNumberInWord(0)} ");
            }
        }

        Console.WriteLine(word.ToString().TrimEnd());
    }

    public static void Playground()
    {
        Console.WriteLine("Reverse method:");
        Console.WriteLine(Reverse(-121));
        Console.WriteLine(Reverse(1212));
        Console.WriteLine(Reverse(1234));
        Console.WriteLine(Reverse(100));
        Console.WriteLine(Reverse(-1234));
        
        Console.WriteLine("GetDigitCount method:");
        Console.WriteLine(GetDigitCount(0));
        Console.WriteLine(GetDigitCount(123));
        Console.WriteLine(GetDigitCount(-12));
        Console.WriteLine(GetDigitCount(5200));

        Console.WriteLine("ConvertNumberToWords method:");
        ConvertNumberToWords(123);
        ConvertNumberToWords(1010);
        ConvertNumberToWords(1000);
        ConvertNumberToWords(-12);
    }
}