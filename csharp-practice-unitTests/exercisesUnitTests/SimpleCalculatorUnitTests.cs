using csharp_practice.exercises;
namespace csharp_practice_unitTests;

[TestClass]
public class SimpleCalculatorUnitTests
{
    /// <summary>
    /// Positive test for getAdditionResult
    /// </summary>
    [TestMethod]
    public void SimpleCalculatorAddition()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.setFirstNumber(5.0);
        calculator.setSecondNumber(4);
        double result = calculator.getAdditionResult();
        Assert.AreEqual(9, result);
    }
    
    /// <summary>
    /// Positive test for getSubtractionResult
    /// </summary>
    [TestMethod]
    public void SimpleCalculatorSubtraction()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.setFirstNumber(5.0);
        calculator.setSecondNumber(4);
        double result = calculator.getSubtractionResult();
        Assert.AreEqual(1, result);
    }
    
    /// <summary>
    /// Positive test for getMultiplicationResult
    /// </summary>
    [TestMethod]
    public void SimpleCalculatorMultiplication()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.setFirstNumber(5.25);
        calculator.setSecondNumber(0);
        double result = calculator.getMultiplicationResult();
        Assert.AreEqual(0, result);
    }
    
    /// <summary>
    /// Positive test for getDivisionResult
    /// </summary>
    [TestMethod]
    public void SimpleCalculatorDivision()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.setFirstNumber(5.25);
        calculator.setSecondNumber(1);
        double result = calculator.getDivisionResult();
        Assert.AreEqual(5.25, result);
    }
    
    /// <summary>
    /// Negative test for getDivisionResult
    /// </summary>
    [TestMethod]
    public void SimpleCalculatorDivisionNegativeTest()
    {
        SimpleCalculator calculator = new SimpleCalculator();
        calculator.setFirstNumber(5.25);
        calculator.setSecondNumber(0);
        double result = calculator.getDivisionResult();
        Assert.AreEqual(0, result);
    }
}