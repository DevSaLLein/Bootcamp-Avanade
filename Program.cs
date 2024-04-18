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

        DateTime dataAtual = DateTime.Now;

        // Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));
        // Console.WriteLine(dataAtual.ToString("HH:mm:FF"));

        // ToInt64 = Long
        // int a = Convert.ToInt32("5");

        // Não aceita null
        // int b = int.Parse("5");

        // Console.WriteLine($"{a},{b}");

        // int inteiro = 5;
        // string word = inteiro.ToString();


        // O contrário daria [error]    
        // int < double < long
        // int intValue = 4;
        // double doubleValue = intValue;
        // long longValue = intValue;

        // ---------------------------------------

        // string stringError = "15-";


        // Caso seja convertido com sucesso, o valor será jogado em "intError"
        // _ = int.TryParse(stringError, out int intError);

        // Console.WriteLine(intError);

        // int quantidadeEmEstoque = 10;

        // int quantidadeCompra = 4;

        // bool validation = quantidadeEmEstoque >= quantidadeCompra;

        // if(validation) 
        //     Console.WriteLine("Venda realizada");
        // else 
        //     Console.WriteLine("Venda não realizada");


        // Console.WriteLine("Digite uma letra");

        // string letra = Console.ReadLine();
        
        // switch(letra) 
        // {
        //     case "a":
        //     case "e":
        //     case "i":
        //     case "o":
        //     case "u":
        //         Console.WriteLine("Vogal");
        //         break;

        //     default:
        //         Console.WriteLine("Não é vogal");
        //         break;
        // }

        Calculadora calculadora = new Calculadora();

        calculadora.Somar(1, 4);        
    } 
}