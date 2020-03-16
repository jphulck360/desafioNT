using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioNTConsult.Classes
{
    public class Cliente
    {
        public string Codigo { get; set; }
        public string Cnpj { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }

        public Cliente()
        {

        }

        public Cliente(string codigo, string cnpj, string nome, string area)
        {
            this.Codigo = codigo;
            this.Cnpj = cnpj;
            this.Nome = nome;
            this.Area = area;
        }
    }
}
