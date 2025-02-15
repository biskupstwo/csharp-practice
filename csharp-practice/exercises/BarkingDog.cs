namespace csharp_practice.exercises;

public class BarkingDog
{
    public static Boolean ShouldWakeUp(Boolean isBarking, int hours)
    {
        return isBarking && ((hours > 22 && hours <= 24) || (hours >= 0 && hours < 8));
    }

    public static void Playground()
    {
        Console.WriteLine(ShouldWakeUp(true, 1));
        Console.WriteLine(ShouldWakeUp(false, 2));
        Console.WriteLine(ShouldWakeUp(true, 8));
        Console.WriteLine(ShouldWakeUp(true, -1));
        Console.WriteLine(ShouldWakeUp(true, 23));
        Console.WriteLine(ShouldWakeUp(true, 25));
    }
}