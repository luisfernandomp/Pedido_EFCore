using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Efcore2.Domains
{
        /// <summary>
        /// Definição da classe Produto
        /// </summary>
    public class Produto : BaseDomain
    {
            public string Nome { get; set; }
            public float Preco { get; set; }

            //Usada para receber o arquivo
            [NotMapped]
            [JsonIgnore]
            public IFormFile Imagem { get; set; }

            //url da imagem salva localmente
            public string UrlImagem { get; set; }

            //Relacionamento com a tabela PedidoItem 1,N
            public List<PedidoItem> PedidosItens { get; set; }
    }
}
