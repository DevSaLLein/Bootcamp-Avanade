using Propriedades__métodos_e_construtores.models;
using Propriedades_métodos_e_construtores.models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        Pessoa p2 = new Pessoa("Isaac", "Andrade", 17);

        Curso cursoEngenhariaDeSoftware = new Curso("Engenharia de Software");

        Console.WriteLine(cursoEngenhariaDeSoftware.AdicionarAluno(p2));
        cursoEngenhariaDeSoftware.listarAlunos();
    }
} 