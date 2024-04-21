using Propriedades__métodos_e_construtores.models;
using Propriedades_métodos_e_construtores.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa devsallein = new Pessoa
        {
            Nome = "Isaac",
            Sobrenome = "Andrade",
            Idade = 17,
        };


        Curso cursoEngenhariaDeSoftware = new Curso();
        cursoEngenhariaDeSoftware.NomeDoCurso = "Engenharia de Software";

        Console.WriteLine(cursoEngenhariaDeSoftware.AdicionarAluno(devsallein));
        cursoEngenhariaDeSoftware.listarAlunos();
    }
} 