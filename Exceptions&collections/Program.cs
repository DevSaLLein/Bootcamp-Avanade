internal class Program
{
    private static void Main()
    {

        try 
        {
            string[] linhasDoArquivo = File.ReadAllLines("./Arquivos/arquivoLeitura.txt");

            foreach (string linha in linhasDoArquivo)
            {
                Console.WriteLine(linha);
            }
        }

        catch (FileNotFoundException error)
        {
            Console.WriteLine("Arquivo não encontrado: " + error.Message);
        }

        catch (DirectoryNotFoundException error)
        {
            Console.WriteLine("Diretório não encontrado: " + error.Message);
        } 

        catch (Exception error)
        {
            Console.WriteLine("Ocorreu um erro: " + error.Message);
        }


        Queue<int> filaDeInteiros = new Queue<int>();

        // Adiciona  um elemento no FIM da fila
        filaDeInteiros.Enqueue(1);
        filaDeInteiros.Enqueue(2);

        // Remove o Primeiro elemento
        Console.WriteLine($"Removendo o número: {filaDeInteiros.Dequeue()}");

        foreach (int number in filaDeInteiros)
        {
            Console.WriteLine(number);
        }

        Stack<int> pilhaDeInteiros = new Stack<int>();

        pilhaDeInteiros.Push(1);
        pilhaDeInteiros.Push(2);

        // Remove o ultimo elemento adicionado
        Console.WriteLine($"Removendo o número: {pilhaDeInteiros.Pop()}");

        foreach(int number in pilhaDeInteiros)
        {
            Console.WriteLine(number);
        }

        Dictionary<string, string> dicionarioDosEstados = new Dictionary<string, string>();
        dicionarioDosEstados.Add("SP", "São Paulo");
        dicionarioDosEstados.Add("CE", "Ceará");

        foreach(var item in dicionarioDosEstados)
        {
            Console.WriteLine($"{item.Key} - {item.Value}");
        }

        dicionarioDosEstados.Remove("SP");
        dicionarioDosEstados["CE"] = "Ceará - valor alterado";

        if(dicionarioDosEstados.ContainsKey("CE"))
        {
            Console.WriteLine(dicionarioDosEstados["CE"]);
        }
        else 
        {
            Console.WriteLine("Estado não encontrado");
        }
    }

}