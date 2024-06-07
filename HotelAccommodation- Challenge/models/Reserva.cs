namespace Hotel_accommodation.models
{
    public class Reserva(List<Pessoa> hospedes, Suite suite, int diasReservados)
    {
        private List<Pessoa> Hospedes 
        {
            get => hospedes; 
            set 
            {
                if(hospedes.Count <= suite.CapacidadeSuite) hospedes = value;

                throw new Exception("Não é possível reservar mais que a capacidade da suite");
            }
        }
        
        private Suite Suite {get; set;} = new Suite(suite.TipoSuite, suite.CapacidadeSuite, suite.ValorDiaria);

        private int DiasReservados 
        {
            get => diasReservados; 
            set => diasReservados = value;
        }

        public int ObterQuantidadeHospedes() => Hospedes.Count;

        public decimal ObterValorTotal() 
        {
            if(DiasReservados >= 10)
                return (suite.ValorDiaria * diasReservados) - (suite.ValorDiaria * diasReservados / 10);
            else
                return suite.ValorDiaria * diasReservados;           
        }
        
    }
}