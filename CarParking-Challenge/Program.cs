using Estacionamento.model;

internal class Program
{
    private static void Main()
    {
        EstacionamentoDeCarros estacionamento = new EstacionamentoDeCarros("DevAvanades");
        Car carro1 = new Car("Gol", 12, 2);

        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.WriteLine("1 - Estacionar novo carro");
            Console.WriteLine("2 - Visualizar carros cadastrados");
            Console.WriteLine("3 - Tirar carro do estacionamento");
            Console.WriteLine("4 - Sair");

            switch (Console.ReadLine())
            {
                case "1":
                    estacionamento.EstacionarCarro();
                    break;
                case "2":
                    estacionamento.ListarCarrosEstacionados();                    
                    break;
                case "3":
                    estacionamento.SairDoEstacionamento();
                    break;
                case "4":
                    exibirMenu = false;
                    break;
                default:
                    Console.WriteLine("Ação não identificada, por favor, tente novamente");
                    break;
            }
        }
    }
}