using Propriedades_métodos_e_construtores.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa devsallein = new Pessoa
        {
            Nome = "Isaac",
            Idade = 17,
        };

        Console.WriteLine(devsallein.ApresentarPessoa());
    }
} 