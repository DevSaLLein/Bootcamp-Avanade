using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Classes_abstratas___Interfaces.Inferfaces;

namespace Classes_abstratas___Interfaces.models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Mult(int num1, int num2)
        {
            return num1  * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}