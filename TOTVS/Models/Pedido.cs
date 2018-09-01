using System.Collections.Generic;

namespace TOTVS.Models
{
    public class Pedido
    {
        public int PedidoID { get; set; }
        //public int ClienteID { get; set; }
        //public Cliente Cliente { get; set; }
        public float ValorTotal { get; set; }
        public ICollection<ProdutoPedido> ProdutoPedidos { get; set; }

    }
}
