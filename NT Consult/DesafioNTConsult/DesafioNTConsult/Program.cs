using System;
using System.Collections.Generic;
using System.IO;
using DesafioNTConsult.Classes;

namespace DesafioNTConsult
{
    class Program
    {
        static void Main(string[] args)
        {
            Processo p = new Processo();
            p.verificaQtdVendedores();
            p.verificaQtdClientes();
            p.maiorVenda();
        }
    }
}
