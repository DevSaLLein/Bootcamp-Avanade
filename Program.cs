using System.Runtime.InteropServices;
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


        // Calculadora calculadora = new Calculadora();
        // calculadora.Somar(1, 4);

        // for(int contador = 0; contador <= 10; contador++) 
        // {
        //     Console.WriteLine(contador);
        // }  

        // int contadorWhile = 0;
        // while(contadorWhile <= 10) 
        // {
        //     Console.WriteLine(contadorWhile); 
        //     contadorWhile++;
        // }      


        // int numeroDigitado, soma = 0;

        // do
        // {
        //     Console.WriteLine("Um número para ser somando");
        //     numeroDigitado = Convert.ToInt32(Console.ReadLine());

        //     soma += numeroDigitado;

        // } while(numeroDigitado != 0);

        // Console.WriteLine(soma);

        string option;
        bool exibirMenu = false;

        while(exibirMenu)
        {
            Console.Clear();
            Console.WriteLine("Digite uma opção");
            Console.WriteLine("1 - Cadastro");
            Console.WriteLine("2 - Consulta");
            Console.WriteLine("3 - Exclusão");
            Console.WriteLine("4 - Sair"); 

            option = Console.ReadLine();
            
            switch(option)
            {
                case "1":
                    Console.WriteLine("cadastro");
                    break;
                    
                case "2":
                    Console.WriteLine("consultar");
                    break;
            
                case "3":
                    Console.WriteLine("exclusão");
                    break;

                case "4":
                    Console.WriteLine("sair");
                    // Environment.Exit(0); 
                    exibirMenu = false;
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    } 
}