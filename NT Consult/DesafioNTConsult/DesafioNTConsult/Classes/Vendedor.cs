using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioNTConsult.Classes
{
    public class Vendedor
    {
        public string Codigo { get; set; }
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public float Salario { get; set; }

        public Vendedor()
        {

        }

        public Vendedor(string codigo, string cpf, string nome, float salario)
        {
            this.Codigo = codigo;
            this.Cpf = cpf;
            this.Nome = nome;
            this.Salario = salario;
        }
    }
}
