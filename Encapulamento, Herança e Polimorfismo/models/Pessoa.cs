using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Encapsulamento__Herança_e_Polimorfismo.models
{
    public class Pessoa 
    {
         string Nome {get; set;}
         string Sobrenome {get; set;}

         public virtual void Teste() 
         {
            Console.WriteLine("Teste");
         }
    }
}