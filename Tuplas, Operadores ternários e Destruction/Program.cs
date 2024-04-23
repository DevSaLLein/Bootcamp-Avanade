using System.Security.Cryptography.X509Certificates;
using Tuplas__Operadores_ternários_e_Destruction.models;

internal class Program
{
    private static void Main()
    {
        (int Id, string Nome, string Sobrenone) tuplaExemplo = (1, "Isaac", "Andrade");
        ValueTuple<int , string, string>  outraTupla = (1, "Isaac", "Andrade");
        var outroExemploDeTupla = Tuple.Create(1, "Isaac", "Andrade");

        Console.WriteLine(tuplaExemplo.Id);
        Console.WriteLine(tuplaExemplo.Nome);
        Console.WriteLine(tuplaExemplo.Sobrenone);  

        string caminho = "../Exceptions&collections/Arquivos/arquivoLeitura.txt";

        (bool, string[], int) LerArquivos(string caminho)
        {   
            try
            {
                string[] linhas = File.ReadAllLines(caminho);
                return (true, linhas, linhas.Count());
            } 
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
                return (false, ["File not found"], 0); 
            }
        }  

        // _ = Descarte de valores que não serão utilizados

        (bool success, string[] linhasDoArquivo, _) = LerArquivos(caminho);


        // Deconstruct 
        Pessoa p1 = new Pessoa("Pessoa", "Fulano");
        (string nome, string sobrenome) = p1;




        // IF ternário

        int numero = 15;
        bool ehPar = numero % 2 ==0;

        Console.WriteLine($"O número {numero} é" + (ehPar ? "par" : "impar"));
    }
}