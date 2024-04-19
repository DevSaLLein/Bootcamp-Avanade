namespace BibliotecaDeClassesExemplo.model

{
    public class Calculadora
    {
        
        public void Somar(int a, int b)
        {
            Console.WriteLine($"{a} + {b} = {a + b}");
        }

        public void Subtrair(int a, int b)
        {
            Console.WriteLine($"{a} - {b} = {a + b}");
        }

        public void Multiplicar(int a, int b)
        {
            Console.WriteLine($"{a} * {b} = {a + b}");
        }

        public void Dividir(int a, int b)
        {
            Console.WriteLine($"{a} / {b} = {a + b}");
        }

        public void Potencia(int a, int b)
        {
            double resultado = Math.Pow(a, b);
            Console.WriteLine($"{a}^{b} = {resultado}");
        }

        // Funções trigonométricas

        public void Seno(double angulo) 
        {
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sin(radiano);
            double senoRounded = Math.Round(seno, 4);
            Console.WriteLine($"O seno de {angulo}° é {senoRounded}");
        }

        public void Cosseno(double angulo) 
        {
            double radiano = angulo * Math.PI / 180;
            double cos = Math.Cos(radiano);
            double cosRounded = Math.Round(cos, 4);
            Console.WriteLine($"O seno de {angulo}° é {cosRounded}");
        }

        public void Tangente(double angulo) 
        {
            double radiano = angulo * Math.PI / 180;
            double tang = Math.Tan(radiano);
            double tangRounded = Math.Round(tang, 4);
            Console.WriteLine($"O seno de {angulo}° é {tangRounded}");
        }

        public void RaizQuadrada(double x) 
        {
            double raiz = Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {raiz}");
        }
        
    }
}