using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioNTConsult.Classes
{
    public class Venda
    {
        public string Codigo { get; set; }
        public int IdVenda { get; set; }

        public Venda()
        {

        }

        public Venda(string codigo, int id_venda)
        {
            this.Codigo = codigo;
            this.IdVenda = id_venda;
        }
    }
}
