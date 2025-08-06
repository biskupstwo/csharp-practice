namespace csharp_practice.exercises.Polymorphism;

public class Car
{
    private bool _engine;
    private int _cylinders;
    private string _name;
    private int _wheels;

    public Car(int cylinders, string name)
    {
        _engine = true;
        _cylinders = cylinders;
        _name = name;
        _wheels = 4;
    }

    public int GetCylinders() => _cylinders;
    public string GetName() => _name;
        
    public virtual string StartEngine() => "Car -> StartEngine()";
    public virtual string Accelerate() => "Car -> Accelerate()";
    public virtual string Brake() => "Car -> Brake()";
}