using Nuget__Serializar_e_Atributos.models;
using Newtonsoft.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Venda> listaDeVendas = new List<Venda>();
        DateTime dataAtual = DateTime.Now;

        Venda v1 = new Venda(1, "Chocolate", 1.40m, dataAtual);
        Venda v2 = new Venda(2, "Leite", 2.40m, dataAtual);

        listaDeVendas.Add(v1);
        listaDeVendas.Add(v2);

        string jsonSerializer = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);

        File.WriteAllText("Arquivos/vendas.json", jsonSerializer);
        
        // Console.WriteLine(jsonSerializer);

        string conteudoArquivo = File.ReadAllText("./Arquivos/vendas.json");

        List<Venda> listaVendaDoConteudo = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

        foreach (Venda venda in listaVendaDoConteudo)
        {
            Console.WriteLine($"Id do produto: {venda.Id}");
            Console.WriteLine($"Nome do produto: {venda.Produto}");
            Console.WriteLine($"Preço do produto: R$ {venda.Preco}");
            Console.WriteLine($"Data da compra: {venda.DataVenda:dd/MM/yyy HH:mm:ss}\n");
        }
    }
}