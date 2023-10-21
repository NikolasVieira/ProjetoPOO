using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPOO.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nome { get; set; }
        public string RG {  get; set; }
        public string CPF { get; set; }
        public DateTime DtNascimento { get; set; }
        public string Telefone { get; set; }

    }
}
