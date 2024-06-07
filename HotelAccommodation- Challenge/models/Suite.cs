namespace Hotel_accommodation.models
{
    public class Suite(string tipoSuite, int capacidadeSuite, decimal valorDiaria)
    {
        public string TipoSuite 
        {
            get => tipoSuite;
            set 
            {
                if(value == "") throw new Exception("O tipo da suíte não pode ser vazio");
                
                tipoSuite = value;
            }
        }

        public int CapacidadeSuite
        {
            get => capacidadeSuite;
            set
            {
                if(value <= 0) throw new Exception("A capacidade da suíte deve ser maior que 0");

                capacidadeSuite = value;
            }
        }

        public  decimal ValorDiaria 
        {
            get => valorDiaria;
            set => valorDiaria = value;
        }
    }
}