using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nuget__Serializar_e_Atributos.models
{
    public class Venda(int id, string produto, decimal preco, DateTime dataVenda)
    {
        public  int Id { get; set; } = id;

        [JsonProperty("Produto")]
        public  string? Produto { get; set; } = produto;
        public  decimal Preco { get; set; } = preco;
        public DateTime DataVenda { get; set; } = dataVenda;
    }
}