namespace csharp_practice.exercises;

public class SpeedConverter
{
    long ToMilesPerHour(double kilometersPerHour)
    {
        return kilometersPerHour > 0 ? (long)Math.Round(0.621371 * kilometersPerHour) : -1;
    }

    public void PrintConversion(double kilometersPerHour)
    {
        long milesPerHour = ToMilesPerHour(kilometersPerHour);
        string output = milesPerHour != -1 ? $"{kilometersPerHour} km/h = {milesPerHour} mi/h" : "Invalid Value";
        Console.WriteLine(output);
    }

    public static void Playground()
    {
        var speedConverter = new SpeedConverter();
        speedConverter.PrintConversion(1.5); 
        speedConverter.PrintConversion(10.25); 
        speedConverter.PrintConversion(-5.6);
        speedConverter.PrintConversion(25.42);
        speedConverter.PrintConversion(75.114);
    }
}