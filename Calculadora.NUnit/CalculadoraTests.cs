using NUnit.Framework;
using NUnit.Framework.Legacy;
using System.Runtime.ExceptionServices;
using CalcTest = Calculadora.Util;

namespace Calculadora.NUnit;

[TestFixture]
public class CalculadoraTests
{
    private CalcTest.Calculadora _calc;

    [SetUp]
    public void Setup()
    {
        _calc = new CalcTest.Calculadora();
    }

    [Test]
    public void TestSomar()
    {        
        Assert.That(_calc.Somar(2, 2), Is.EqualTo(4));
    }    
    
    [Test]
    public void TestSubtrair()
    {        
        Assert.That(_calc.Subtrair(2, 2), Is.EqualTo(0));
    }

    [Test]
    [Ignore("Método ainda não implementado")]
    public void TestMultiplicar() { }
    
    [Test]
    [Ignore("Método ainda não implementado")]
    public void TestDividir() { }

    [TearDown]
    public void TearDown()
    {
        _calc = null;
    }
}
