using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Classes_abstratas___Interfaces.Inferfaces
{
    public interface ICalculadora
    {
        int Somar(int num1, int num2);
        int Sub(int num1, int num2);
        int Mult(int num1, int num2);
        int Dividir(int num1, int num2);
    }
}