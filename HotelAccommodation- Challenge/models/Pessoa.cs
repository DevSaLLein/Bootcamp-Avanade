namespace Hotel_accommodation.models
{
    public class Pessoa(string nome, string sobrenome)
    {
        public string Nome 
        {
            get => nome;

            set
            {
                if(value == "") throw new Exception("O nome não pode ser vazio");
                
                nome = value;
            }
        }

        public string Sobrenome 
        {
            get => sobrenome;

            set 
            {
                if(value == "") throw new Exception("O sobrenome não pode ser vazio");

                sobrenome = value;
            }
        } 

    }
}