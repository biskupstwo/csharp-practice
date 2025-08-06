namespace csharp_practice.exercises.Polymorphism;

public class Holden(int cylinders, string name) : Car(cylinders, name)
{
    public override string StartEngine() => "Holden -> StartEngine()";
    public override string Accelerate() => "Holden -> Accelerate()";
    public override string Brake() => "Holden -> Brake()";
}