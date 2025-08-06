namespace csharp_practice.exercises.Composition;

public class Lamp(string style, bool battery, int globRating)
{
    private string _style = style;
    private bool _battery = battery;
    private int _globRating = globRating;

    public void TurnOn() => Console.WriteLine("Lamp -> Turning on");
    public string GetStyle() => _style;
    public bool IsBattery() => _battery;
    public int GetGlobRating() => _globRating;
}