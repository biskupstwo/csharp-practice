using PNOexercise = csharp_practice.exercises.PositiveNegativeOrZero;
namespace csharp_practice_unitTests;

[TestClass]
public class PositiveNegativeOrZeroUnitTests
{
    
    /// <summary>
    /// Positive test for checkNumber - positive parameter
    /// </summary>
    [TestMethod]
    public void CheckNumberPositiveParameter()
    {
        var stringWriter = new StringWriter();
        TextWriter originalOut = Console.Out;
        Console.SetOut(stringWriter);
        
        string expectedMessage = "positive";
        
        PNOexercise.CheckNumber(10);
        var output = stringWriter.ToString().Trim();
            
        Assert.AreEqual(expectedMessage, output);
        Console.SetOut(originalOut);
    }
    
    /// <summary>
    /// Positive test for checkNumber - zero parameter
    /// </summary>
    [TestMethod]
    public void CheckNumberZeroParameter()
    {
        var stringWriter = new StringWriter();
        TextWriter originalOut = Console.Out;
        Console.SetOut(stringWriter);
        string expectedMessage = "zero";
        
        PNOexercise.CheckNumber(0);
        var output = stringWriter.ToString().Trim();
            
        Assert.AreEqual(expectedMessage, output);
        Console.SetOut(originalOut);
    }
    
    /// <summary>
    /// Positive test for checkNumber - negative parameter
    /// </summary>
    [TestMethod]
    public void CheckNumberNegativeParameter()
    {
        var stringWriter = new StringWriter();
        TextWriter originalOut = Console.Out;
        Console.SetOut(stringWriter);
        
        string expectedMessage = "negative";
        
        PNOexercise.CheckNumber(-5);
        var output = stringWriter.ToString().Trim();
            
        Assert.AreEqual(expectedMessage, output);
        Console.SetOut(originalOut);
    }
}