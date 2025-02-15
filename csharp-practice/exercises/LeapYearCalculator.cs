namespace csharp_practice.exercises;

public class LeapYearCalculator
{
    public static Boolean IsLeapYear(int year)
    {
        Boolean isLeapYear = false;
        if (year < 0) return isLeapYear;
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    isLeapYear = true;
                }
            }
            else
            {
                isLeapYear = true;
            }
        }
        return isLeapYear;
    }

    public static void Playground()
    {
        Console.WriteLine(IsLeapYear(-1600));
        Console.WriteLine(IsLeapYear(1600));
        Console.WriteLine(IsLeapYear(2017));
        Console.WriteLine(IsLeapYear(2000));
        Console.WriteLine(IsLeapYear(2018));
        Console.WriteLine(IsLeapYear(2020));
    }
}