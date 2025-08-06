namespace csharp_practice.exercises.Polymorphism;

public class Mitsubishi(int cylinders, string name) : Car (cylinders, name)
{
    public override string StartEngine() => "Mitsubishi -> StartEngine()";
    public override string Accelerate() => "Mitsubishi -> Accelerate()";
    public override string Brake() => "Mitsubishi -> Brake()";
}