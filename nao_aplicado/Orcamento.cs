using System;
using System.Collections.Generic;
using System.Text;

namespace nao_aplicado
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public List<Item> Itens { get; set; }

        public Orcamento()
        {
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Valor;
        }
    }
}
