using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TOTVS.Models
{
    public class Pedido
    {
        public int ID { get; set; }
        public int Cliente_ID { get; set; }
        public float ValorTotal { get; set; }
        public Produto Produto { get; set; }

    }
}
