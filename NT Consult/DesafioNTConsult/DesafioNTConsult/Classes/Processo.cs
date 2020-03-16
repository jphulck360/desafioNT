using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DesafioNTConsult.Classes
{
    public class Processo
    {
        public void listarTodos() 
        {
            List<string> nomes = new List<string>();
            List<int> idades = new List<int>();

            using (StreamReader reader = new StreamReader(@"...\...\...\HOMEPATH\data\in\arquivoEntrada.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string[] valores = linha.Split('ç');
                    nomes.Add(valores[0]);
                    idades.Add(int.Parse(valores[1]));
                }
            }

            for (int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine("Nome: " + nomes[i] + " - Idade: " + idades[i]);
            }

            Console.ReadKey();
        }

        public void verificaQtdVendedores()
        {
            List<Vendedor> vendedor = new List<Vendedor>();
            Vendedor v;

            using (StreamReader reader = new StreamReader(@"HOMEPATH\data\in\arquivoEntrada.txt"))
            {
                while (!reader.EndOfStream)
                {                    
                    string linha = reader.ReadLine();
                    string[] valores = linha.Split('ç','-');

                    if(valores[0] == "001")
                    {
                        v = new Vendedor();
                        v.Codigo = valores[0];
                        v.Cpf = valores[1];
                        v.Nome = valores[2];
                        v.Salario = float.Parse(valores[3]);
                        vendedor.Add(v);
                    } 
                }
            }

            for (int i = 0; i < vendedor.Count; i++)
            {
                Console.WriteLine("Codigo: " + vendedor[i].Codigo + " - " +
                                  "CPF: " + vendedor[i].Cpf + " - " +
                                  "Nome: " + vendedor[i].Nome + " - " +
                                  "Salário: " + vendedor[i].Salario);
            }
            var qtd = vendedor.Count;
            Console.WriteLine("Quantidade de vendedores: "+qtd.ToString());

            string path = @"HOMEPATH\data\out\arquivoSaida.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Quantidade de vendedores: " + qtd.ToString());
                }
            }

            Console.ReadKey();
        }

        public void verificaQtdClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            Cliente c;

            //using (StreamReader reader = new StreamReader(@"C:NT Consult\DesafioNTConsult\DesafioNTConsult\HOMEPATH\data\in\arquivoOriginal.txt"))
            using (StreamReader reader = new StreamReader(@"HOMEPATH\data\in\arquivoEntrada.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string[] valores = linha.Split('ç');

                    if (valores[0] == "002")
                    {
                        c = new Cliente();
                        c.Codigo = valores[0];
                        c.Cnpj = valores[1];
                        c.Nome = valores[2];
                        c.Area = valores[3];
                        listaClientes.Add(c);
                    }
                }
            }

            for (int i = 0; i < listaClientes.Count; i++)
            {
                Console.WriteLine("Codigo: " + listaClientes[i].Codigo + " - " +
                                  "CNPJ: " + listaClientes[i].Cnpj + " - " +
                                  "Nome: " + listaClientes[i].Nome + " - " +
                                  "Área: " + listaClientes[i].Area);
            }
            var qtd = listaClientes.Count;

            string path = @"HOMEPATH\data\out\arquivoSaida.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Quantidade de clientes: " + qtd.ToString());
                }
            }
            Console.ReadKey();
        }

        public void maiorVenda()
        {
            List<Venda> listaVendas = new List<Venda>();
            List<Item> listaItens = new List<Item>();
            Venda v;
            Item item;

            using (StreamReader reader = new StreamReader(@"HOMEPATH\data\in\arquivoEntrada.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string linha = reader.ReadLine();
                    string[] valores = linha.Split('ç','-');

                    if (valores[0] == "003")
                    {
                        v = new Venda();
                        v.Codigo = valores[0];
                        v.IdVenda = int.Parse(valores[1]);

                        item = new Item();
                        item.ItemId = int.Parse(valores[2]);
                        item.ItemPreco = float.Parse(valores[3]);
                        item.ItemQtd = int.Parse(valores[4]);
                        item.VendaId = v.IdVenda;
                        item.NomeVendedor = valores[5];

                        listaVendas.Add(v);
                        listaItens.Add(item);
                    }
                }
            }

            for (int i = 0; i < listaVendas.Count; i++)
            {
                Console.WriteLine("Codigo: " + listaVendas[i].Codigo + " - " +
                                  "CNPJ: " + listaVendas[i].IdVenda + " - " +
                                  "Item Id: " + listaItens[i].ItemId + " - " +
                                  "Preço: " + listaItens[i].ItemPreco + " - " +
                                  "Quantidade: " + listaItens[i].ItemQtd + " - " +
                                  "Vendedor: " + listaItens[i].NomeVendedor);
            }

            Console.ReadKey();

            var preco_max = (from x in listaItens select x.ItemPreco).Max();
            var piorVendedor = (from x in listaItens select x.ItemQtd).Min();
            var venda = (from x in listaItens where x.ItemPreco == preco_max select x.VendaId).FirstOrDefault();


            string path = @"HOMEPATH\data\out\arquivoSaida.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("ID venda mais cara: " + venda);
                    sw.WriteLine("Pior vendedor: " + piorVendedor);
                }
            }

            Console.ReadKey();
        }
    }
}
