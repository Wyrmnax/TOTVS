
using System.Collections.Generic;

namespace TOTVS.Models
{
    public class Produto
    {
        public int ProdutoID { get; set; }
        public string Descricao { get; set; } 
        public float Valor { get; set; }
        public ICollection<ProdutoPedido> ProdutoPedidos { get; set; }
}
}
