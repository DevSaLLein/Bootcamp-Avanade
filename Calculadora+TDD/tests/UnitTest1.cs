using Calculadora_TDD.Models;

namespace tests;

public class UnitTest1
{
    private CalculadoraModel calculator = new CalculadoraModel();

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 3, 6)]
    public void TesteSomar(int num1, int num2, int resultExpected)
    {
        int resultCalculator = calculator.Somar(num1, num2);

        Assert.Equal(resultExpected, resultCalculator);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(4, 3, 1)]
    public void TesteDiminuir(int num1, int num2, int resultExpected)
    {
        int resultCalculator = calculator.Diminuir(num1, num2);

        Assert.Equal(resultExpected, resultCalculator);
    }

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(3, 3, 9)]
    public void TesteMultiplicar(int num1, int num2, int resultExpected)
    {
        int resultCalculator = calculator.Multiplcar(num1, num2);

        Assert.Equal(resultExpected, resultCalculator);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(3, 3, 1)]
    public void TesteDividir(int num1, int num2, int resultExpected)
    {
        int resultCalculator = calculator.Dividir(num1, num2);

        Assert.Equal(resultExpected, resultCalculator);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Assert.Throws<DivideByZeroException>(() => calculator.Dividir(3, 0));
    }

    [Fact]
    public  void TestarHistorico()
    {
        calculator.Somar(1, 2);
        calculator.Somar(1, 5);
        calculator.Somar(3, 2);
        calculator.Somar(7, 2);

        var lista = calculator.Historico();

        Assert.NotEmpty(calculator.Historico());
        Assert.Equal(3, lista.Count);
    }
}