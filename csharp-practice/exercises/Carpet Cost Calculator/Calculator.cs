namespace csharp_practice.exercises.Carpet_Cost_Calculator;

public class Calculator
{
    private Floor _floor;
    private Carpet _carpet;

    public Calculator(Floor floor, Carpet carpet)
    {
        _floor = floor;
        _carpet = carpet;
    }

    public double GetTotalCost() => _floor.GetArea() * _carpet.GetCost();
}