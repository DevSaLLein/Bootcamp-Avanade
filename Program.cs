using dotnet.model;

internal class Program
{
    private static void Main()
    {
        Pessoa devsallein = new Pessoa
        {
            Nome = "Isaac",
            Idade = 17
        };

        Console.WriteLine(devsallein.Apresentar());
    }
}