namespace Estacionamento.model

{
    public class Car(string placaDoCarro, float valorInicial, float valorPorHora)
    {

        string PlacaDoCarro 
        { 
            get => placaDoCarro;

            set {
                if (value.Length!= 7)
                {
                    throw new Exception("A placa do carro deve conter 7 caracteres");
                }
                PlacaDoCarro = value;
            }
        }

        float ValorInicial 
        {
            get => valorInicial; 
            set => valorInicial = value;
        }

        float ValorPorHora 
        { 
            get => valorPorHora;  
            set => valorPorHora = value;
        }

        public string GetPlacaDoCarro(){
            return PlacaDoCarro;
        }

        public  float GetValorPorHora(){
            return ValorPorHora;
        }

        public float GetValorInicial(){
            return ValorInicial;
        }

        public void SetPlacaDoCarro(string placaDoCaro)
        {
            PlacaDoCarro = placaDoCaro;
        }

        public  void setValorInicial(string valorInicial)
        {
            ValorInicial = float.Parse(valorInicial);
        }

        public void setValorPorHora(string valorPorHora)
        {
            ValorPorHora = float.Parse(valorPorHora);
        }
    }
}