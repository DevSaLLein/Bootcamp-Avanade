using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Tuplas__Operadores_ternários_e_Destruction.models
{
    public class Pessoa
    {
        public Pessoa()
        {
            
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;
        private string _sobrenome;

        public string Nome 
        { 
            get => _nome;

            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("O nome não pode ser vazio");
                }
                else
                {
                    _nome = value;
                }

            }
        }

        public string Sobrenome 
        { 
            get => _sobrenome;

            set 
            {
                if(value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vazio");
                }
                else
                {
                    _sobrenome = value;
                }
            }
        }

        public void Deconstruct(out string nome, out string sobrenome) 
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
    }
}