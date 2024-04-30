using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitáriosClasse.Services
{
    public class CalculadoraService
    {
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool EhPar(int number)
        {
            return number % 2 == 0;
        }
    }
}
