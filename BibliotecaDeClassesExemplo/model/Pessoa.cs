namespace BibliotecaDeClassesExemplo.model

{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public required int Idade { get; set; }

        public string Apresentar() 
        {
            return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";   
        }

        
    }
}
 