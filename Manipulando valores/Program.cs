using System.Globalization;
internal class Program
{
    private static void Main()
    {
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

        decimal valorMonetario = 1282.80M;
        // Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));   

        double porcentagem = .3221;
        // Console.WriteLine(porcentagem.ToString("P"));

        int numeroPersonalizado = 123456;
        // Console.WriteLine(numeroPersonalizado.ToString("##-##-##"));

        DateTime data = DateTime.Now;
        string dataString = "2022-01-22 12:00";

        bool successConvert = DateTime.TryParseExact(
            dataString, 
            "yyyy-MM-dd HH:mm", 
            CultureInfo.InvariantCulture, 
            DateTimeStyles.None, 
            out DateTime dataSpringParse
        );

        if(successConvert) Console.WriteLine(dataSpringParse);
        else Console.WriteLine("Conversão não feita com sucesso, tente novamente");

        // Console.WriteLine(data.ToShortDateString());
        // Console.WriteLine(data.ToShortTimeString());

        // Console.WriteLine(data.ToString("dd/MM/yyyy"));
        // Console.WriteLine(data.ToString("HH:mm:ss"));
    }
}