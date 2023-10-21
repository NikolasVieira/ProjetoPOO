using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPOO.Models
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public string CodBarras { get; set; }
        public string Unidade { get; set; }
        public decimal PrecoVenda { get; set; }
        public int estoqueAtual { get; set; }
    }
}
