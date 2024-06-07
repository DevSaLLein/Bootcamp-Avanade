using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileStore.models
{
    public abstract class Smartphone (
        string numero, 
        string modelo, 
        string imei, 
        int memoria
    )
    {
        public string Numero
        {
            get => numero;
            set => numero = value;
        }

        private string Modelo
        {
            get => modelo;
            set => modelo = value;
        }

        private string IMEI
        {
            get => imei;
            set => imei = value;
        }

        private int Memoria
        {
            get => memoria;
            set => memoria = value;
        }

        public static void Ligar() => Console.WriteLine("Ligando...");

        public static void ReceberLigacao() => Console.WriteLine("Recebendo ligação...");
        
        public abstract void InstalarAplicativo(string nomeApp);
    }
}