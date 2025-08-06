namespace csharp_practice.exercises.Polymorphism;

public class Ford(int cylinders, string name) : Car(cylinders, name)
{
    public override string StartEngine() => "Ford -> StartEngine()";
    public override string Accelerate() => "Ford -> Accelerate()";
    public override string Brake() => "Ford -> Brake()";
}