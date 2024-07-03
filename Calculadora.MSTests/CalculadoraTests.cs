using TDDCalculadora = Calculadora.Util;
namespace Calculadora.MSTests;

[TestClass]
public class CalculadoraTests
{
    private TDDCalculadora.Calculadora _calc;

    [TestInitialize]
    public void Setup()
    {
        _calc = new TDDCalculadora.Calculadora();
    }

    [TestMethod]
    public void TestSomar()
    {        
        Assert.AreEqual(4, _calc.Somar(2, 2));
    }

    [TestMethod]
    public void TestSubtrair()
    {        
        Assert.AreEqual(0, _calc.Subtrair(2, 2));
    }
}