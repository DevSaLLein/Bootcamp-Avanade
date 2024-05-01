using TestesUnitáriosClasse.Services;

namespace TestesUnitáriosX;

public class CalculadoraTests
{
    private CalculadoraService _calculadora;

    public CalculadoraTests(){
        _calculadora = new CalculadoraService();
    }
    
    [Fact]
    public void DeveSomar5Com10ERetornar15()
    {
        // Arrange => Montar cenário
        int num1 = 5;
        int num2 = 10;

        // Act => Chamar e agir (Ação) => Somar
        int result = _calculadora.Somar(num1, num2);

        // Assert => Validação se está correto
        Assert.Equal(15, result);
    }

    [Theory]
    [InlineData(new int[] {2, 4, 6, 8, 10})]
    public void DeveVerificarSeNumeroEhPar(int[] numbers)
    {
       Assert.All(numbers, item => Assert.True(_calculadora.EhPar(item)));
    }
} 