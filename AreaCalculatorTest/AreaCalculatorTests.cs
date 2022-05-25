using Area_Calculator;
using NUnit.Framework;

namespace AreaCalculatorTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Area_Circle_R15()
    {
        double r = 5;
        double expected = 78.53981633974483;
        var result = new Circle(r).GetArea();
        
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void Area_Triangle_A3_B4_C5()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        double expected = 6;
        var result = new Triangle(a, b, c).GetArea();
        
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void Area_Triangle_IsEquilateral_A3_B4_C5()
    {
        double a = 3;
        double b = 4;
        double c = 5;
        bool expected = false;
        var result = new Triangle(a, b, c).IsEquilateralTriangle();
        
        Assert.AreEqual(expected, result);
    }
    
    [Test]
    public void Area_Triangle_IsEquilateral_A5_B5_C5()
    {
        double a = 5;
        double b = 5;
        double c = 5;
        bool expected = true;
        var result = new Triangle(a, b, c).IsEquilateralTriangle();
        
        Assert.AreEqual(expected, result);
    }
}