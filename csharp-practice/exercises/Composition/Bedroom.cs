namespace csharp_practice.exercises.Composition;

public class Bedroom
{
    private string _name;
    private Wall _wall1;
    private Wall _wall2;
    private Wall _wall3;
    private Wall _wall4;
    private Ceiling _ceiling;
    private Bed _bed;
    private Lamp _lamp;

    public Bedroom(string name, Wall wall1, Wall wall2, Wall wall3, Wall wall4, 
        Ceiling ceiling, Bed bed, Lamp lamp)
    {
        _name = name;
        _wall1 = wall1;
        _wall2 = wall2;
        _wall3 = wall3;
        _wall4 = wall4;
        _ceiling = ceiling;
        _bed = bed;
        _lamp = lamp;
    }

    public Lamp GetLamp() => _lamp;

    public void MakeBed()
    {
        Console.Write("Bedroom -> Making bed | ");
        _bed.Make();
    }
}