namespace csharp_practice.exercises;

public class NumberOfDaysInMonth
{

    public static int GetDaysInMonth(int month, int year)
    {
        if (year < 1 || year > 9999) return -1;
        bool isLeapYear = LeapYearCalculator.IsLeapYear(year);

        int days = month switch
        {
            1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
            4 or 6 or 9 or 11 => 30,
            2 => isLeapYear ? 29 : 28,
            _ => -1
        };

        return days;
    }

    public static void Playground()
    {
        Console.WriteLine(GetDaysInMonth(1, 2020));
        Console.WriteLine(GetDaysInMonth(2, 2020));
        Console.WriteLine(GetDaysInMonth(2, 2018));
        Console.WriteLine(GetDaysInMonth(-1, 2020));
        Console.WriteLine(GetDaysInMonth(1, -2020));
    }
}