using Hotel_accommodation.models;
using Newtonsoft.Json;

internal class Program
{
    private static void Main()
    {
        Pessoa pessoa1 = new Pessoa("Isaac", "lima");
        Pessoa pessoa2 = new Pessoa("Isaac", "lima");
        Pessoa pessoa3 = new Pessoa("Isaac", "lima");
        Pessoa pessoa4 = new Pessoa("Isaac", "lima");

        List<Pessoa> pessoas = [pessoa1, pessoa2, pessoa3, pessoa4];

        Suite suite1 = new Suite("normal", 5, 100);
        Suite suiteDasPessoasSerializadas = new Suite("normal", 3, 40);

        Reserva reserva = new Reserva(pessoas, suite1, 10);

        Console.WriteLine(reserva.ObterQuantidadeHospedes());
        Console.WriteLine(reserva.ObterValorTotal());

        Pessoa pessoaDaAPI = new Pessoa("Hospede 1", "Fulano");
        Pessoa pessoaDaAPI1 = new Pessoa("Hospede 1", "Fulano");
        Pessoa pessoaDaAPI2 = new Pessoa("Hospede 1", "Fulano");
        Pessoa pessoaDaAPI3 = new Pessoa("Hospede 1", "Fulano");
        Pessoa pessoaDaAPI4 = new Pessoa("Hospede 1", "Fulano");

        List<Pessoa> listaDePessoasDaAPI = [pessoaDaAPI, pessoaDaAPI1, pessoaDaAPI3, pessoaDaAPI4];

        string jsonSerializer = JsonConvert.SerializeObject(listaDePessoasDaAPI, Formatting.Indented);
        File.WriteAllText("./api/hospedes-da-api.json", jsonSerializer);

        string conteudoDaAPI = File.ReadAllText("./api/hospedes-da-api.json");
        List<Pessoa> pessoasDaAPIDeserializada = JsonConvert.DeserializeObject<List<Pessoa>>(conteudoDaAPI);

        Reserva reservaDasPessoasSerializadas = new Reserva(pessoasDaAPIDeserializada, suiteDasPessoasSerializadas, 11);
    }
}