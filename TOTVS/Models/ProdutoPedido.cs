
using System.ComponentModel.DataAnnotations;

namespace TOTVS.Models
{
    public class ProdutoPedido
    {
        public int PedidoID { get; set; }
        public Pedido Pedido { get; set; }
        public int ProdutoID { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public float ValorTotalProduto { get; set; }
    }
}
