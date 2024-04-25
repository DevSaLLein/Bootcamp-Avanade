using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_abstratas___Interfaces.models
{
    public abstract class Pessoa(string nome)
    {   
        protected string Nome {get; set;} = nome;
    }
}