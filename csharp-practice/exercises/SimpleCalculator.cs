namespace csharp_practice.exercises;

public class SimpleCalculator
{
    private double FirstNumber { get; set; }
    private double SecondNumber { get; set; }

    public void setFirstNumber(double number)
    {
        FirstNumber = number;
    }
    
    public void setSecondNumber(double number)
    {
        SecondNumber = number;
    }
    
    public double getAdditionResult()
    {
        return FirstNumber + SecondNumber;
    }

    public double getSubtractionResult()
    {
        return FirstNumber - SecondNumber;
    }

    public double getMultiplicationResult()
    {
        return FirstNumber * SecondNumber;
    }

    public double getDivisionResult()
    {
        return SecondNumber != 0 ? FirstNumber / SecondNumber : 0;
    }
}