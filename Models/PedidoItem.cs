using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPOO.Models
{
    public class PedidoItem
    {
        public int IdPedidoItem { get; set; }
        public Pedido Pedido { get; set; }
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
    }
}
