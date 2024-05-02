using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFirstAPI.DTOs
{
    public record ContatoDto(int Id, string Nome, string Telefone){}
    
}