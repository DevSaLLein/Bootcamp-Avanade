using  TestesUnitáriosClasse.Services;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        CalculadoraService calculadora = new CalculadoraService();

        int num1 = 5;
        int num2 = 10;

        Console.WriteLine($"{num1} + {num2} = {calculadora.Somar(num1, num2)}");
    }
}