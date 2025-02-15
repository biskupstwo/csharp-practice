namespace csharp_practice.exercises;

public class PlayingCat
{
    public static bool IsCatPlaying(Boolean isSummer, int temperature)
    {
        return isSummer ? (temperature >= 25 && temperature <= 45) : (temperature >= 25 && temperature <= 35);
    }

    public static void Playground()
    {
        Console.WriteLine(IsCatPlaying(true,10));
        Console.WriteLine(IsCatPlaying(false,36));
        Console.WriteLine(IsCatPlaying(false,35));
        Console.WriteLine(IsCatPlaying(true,36));
    }
}