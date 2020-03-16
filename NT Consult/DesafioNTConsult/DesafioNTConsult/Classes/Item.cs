using System;
using System.Collections.Generic;
using System.Text;


namespace DesafioNTConsult.Classes
{
    public class Item
    {
        public int ItemId { get; set; }
        public int ItemQtd { get; set; }
        public float ItemPreco { get; set; }
        public int VendaId { get; set; }
        public string NomeVendedor { get; set; }

        public Item()
        {
            
        }

        public Item(int item_id, int item_qtd, float item_preco, int VendaId, string nomeVendedor)
        {
            this.ItemId = item_id;
            this.ItemQtd = item_qtd;
            this.ItemPreco = item_preco;
            this.VendaId = VendaId;
            this.NomeVendedor = nomeVendedor;
        }
    }
}
