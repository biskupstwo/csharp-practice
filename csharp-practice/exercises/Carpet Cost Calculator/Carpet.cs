namespace csharp_practice.exercises.Carpet_Cost_Calculator;

public class Carpet
{
    private double _cost;

    public Carpet(double cost)
    {
        _cost = cost >= 0 ? cost : 0;
    }

    public double GetCost() => _cost;
}