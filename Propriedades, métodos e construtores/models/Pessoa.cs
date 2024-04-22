namespace Propriedades_métodos_e_construtores.models
{
    public class Pessoa
    {
        public Pessoa(){}
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string? _nome;
        private int _idade;

        public string Nome 
        {
            get => _nome?.ToUpper();
            
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }

                _nome = value;
            } 
        }

        public string? Sobrenome { get; set; }

        public string? NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade 

        {
            get => _idade;

            set
            {
                if(int.IsNegative(value) || value == 0)
                {
                    throw new ArgumentException("Idade não pode ser menor ou igual azero");
                }

                _idade  = value;
            }
        }

        public string ApresentarPessoa() => $"Olá, meu nome é {NomeCompleto} e eu tenho {Idade} anos";
    }
}