using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento__Herança_e_Polimorfismo.models
{
    public class Professor : Pessoa
    {
        public override void Teste()
        {
            Console.WriteLine("Olá eu sou um professor");
        }
    }
}