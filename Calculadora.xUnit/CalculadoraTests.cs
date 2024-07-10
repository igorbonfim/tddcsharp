using CalcTest = Calculadora.Util.Calculadora;

namespace Calculadora.xUnit;
public class CalculadoraTests : IDisposable
{
    private CalcTest _calc;

    public CalculadoraTests() 
    {
        _calc = new CalcTest(3);
    }

    [Fact]
    public void TestSomar()
    {        
        Assert.Equal(8, _calc.Somar(4, 4));
    }

    [Fact] 
    public void TestSomarComLimite() 
    {        
        Assert.Equal(8, _calc.Somar(4, 4));
    }

    [Fact]
    public void TestSomaForaDoLimite() 
    {
        Assert.Throws<ArgumentOutOfRangeException>(() =>
        {            
            _calc.Somar(2, 2);
        });        
    }

    public void Dispose()
    {
        _calc = null;
    }
}
