namespace csharp_practice.exercises;

public class ComplexNumber(double real, double imaginary)
{
    private double _real = real;
    private double _imaginary = imaginary;

    public double GetReal() => _real;
    public double GetImaginary() => _imaginary;

    public void Add(double real, double imaginary)
    {
        _real += real;
        _imaginary += imaginary;
    }
    
    public void Add(ComplexNumber complexNumber)
    {
        _real += complexNumber._real;
        _imaginary += complexNumber._imaginary;
    }

    public void Subtract(double real, double imaginary)
    {
        _real -= real;
        _imaginary -= imaginary;
    }

    public void Subtract(ComplexNumber complexNumber)
    {
        _real -= complexNumber._real;
        _imaginary -= complexNumber._imaginary;
    }
}