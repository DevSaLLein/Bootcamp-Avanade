namespace Calculadora_TDD.Models
{
    public class CalculadoraModel
    {

        private List<string> ListaHistorico = new List<string>();

        public int Somar(int num1, int num2) 
        {
            int result = num1 + num2;

            ListaHistorico.Insert(0, "Result:" + result);

            return result;
        } 

        public int Diminuir(int num1, int num2)
        {
            int result = num1 - num2;

            ListaHistorico.Insert(0, "Result:" + result);

            return result;
        }

        public int Dividir(int num1, int num2)
        {

            int result = num1 / num2;

            ListaHistorico.Insert(0, "Result:" + result);

            return result;
        }

        public int Multiplcar(int num1, int num2)
        {
            int result = num1 * num2;

            ListaHistorico.Insert(0, "Result:" + result);

            return result;
        }

        public List<string> Historico()
        {

            // Deixar apenas os 3 primeiros
            ListaHistorico.RemoveRange(3, ListaHistorico.Count - 3);

            return ListaHistorico;
        }
    }
}