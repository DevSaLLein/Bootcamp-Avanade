using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace dotnet.model
{
    public class Pessoa
    {
        public required string Nome { get; set; }
        public required int Idade { get; set; }

        public string Apresentar() 
        {
            return $"Olá, meu nome é {Nome} e tenho {Idade} anos.";   
        }
    }
}
 