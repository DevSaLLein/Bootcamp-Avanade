namespace Estacionamento.model
{
    public class EstacionamentoDeCarros(string NomeDoEstacionamento)
    {
        string NomeDoEstacionamento { get; set; } = NomeDoEstacionamento;
        List<Car> ListaDosCarrosEstacionados { get; set; } = new List<Car>();

        public void EstacionarCarro()
        {
            Console.Clear();

            Console.WriteLine("Digite a placa do carro");
            string placaDoCarro = Console.ReadLine();

            Console.WriteLine("Digite o valor inicial pago pelo local no estacionamento");
            float valorInicial = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor por hora pago pelo local no estacionamento");
            float valorPorHora = float.Parse(Console.ReadLine());

            Car novoCarro = new Car(placaDoCarro, valorInicial, valorPorHora);

            Console.WriteLine($"O carro de número {novoCarro.GetPlacaDoCarro()} será estacionado");

            ListaDosCarrosEstacionados.Add(novoCarro);
        }

        public void ListarCarrosEstacionados()
        {
            Console.Clear();
            Console.WriteLine($"Lista de carros estacionados no estacionamento {NomeDoEstacionamento}:");
            foreach (Car carro in ListaDosCarrosEstacionados)
            {
                Console.WriteLine($"Carro de número {carro.GetPlacaDoCarro()} está estacionado");
            }
        }

        public void SairDoEstacionamento()
        {
            Console.Clear();
            Console.WriteLine("Digite o número da placa do carro que deseja sair do estacionamento");
            string numeroDaPlacaDoCarro = Console.ReadLine();

            if(FindCarByPlacaDoCarro(numeroDaPlacaDoCarro) != null)
            {
                Console.WriteLine($"O carro de número {numeroDaPlacaDoCarro} será retirado do estacionamento");
                ValorPagarAoSairDoEstacionamento(FindCarByPlacaDoCarro(numeroDaPlacaDoCarro));
                ListaDosCarrosEstacionados.Remove(FindCarByPlacaDoCarro(numeroDaPlacaDoCarro));
            } 
            else
            {
                Console.WriteLine("Carro não encontrado");
            }
        }

        Car FindCarByPlacaDoCarro(string PlacaDoCarro)
        {
            foreach (Car carro in ListaDosCarrosEstacionados)
            {
                if(carro.GetPlacaDoCarro() == PlacaDoCarro) 
                {
                    return carro;
                }
            }
            return null;
        }

        static void ValorPagarAoSairDoEstacionamento(Car carro)
        {
            float valorInicial = carro.GetValorInicial();
            float valorPorHora = carro.GetValorPorHora();

            Console.WriteLine("Quantas horas o carro passou no estacionamento(não minta)?");

            int horasPassadasNoEstacionamento = Convert.ToInt32(Console.ReadLine());

            float valorPagar = valorInicial + horasPassadasNoEstacionamento * valorPorHora;
            Console.WriteLine($"Tendo em vista que o valor inicial foi R$ {valorInicial} o valor a pagar pelo estacionamento será R$ {valorPagar}");
        }
    }
}