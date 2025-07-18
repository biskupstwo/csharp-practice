namespace csharp_practice.exercises;

public class SimpleCalculator
{
    private double firstNumber;
    private double secondNumber;

    public double getFirstNumber()
    {
        return firstNumber;
    }

    public double getSecondNumber()
    {
        return secondNumber;
    }
    
    public void setFirstNumber(double number)
    {
        firstNumber = number;
    }
    
    public void setSecondNumber(double number)
    {
        secondNumber = number;
    }
    
    public double getAdditionResult()
    {
        return firstNumber + secondNumber;
    }

    public double getSubtractionResult()
    {
        return firstNumber - secondNumber;
    }

    public double getMultiplicationResult()
    {
        return firstNumber * secondNumber;
    }

    public double getDivisionResult()
    {
        return secondNumber != 0 ? firstNumber / secondNumber : 0;
    }
}