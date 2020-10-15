using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace aplicado
{
    public class COFINS : TemplateDeImpostoCondicional
    {

        public override bool DeveUsarMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && TemItemComValorMaiorQue100(orcamento);
        }

        public override double MaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool TemItemComValorMaiorQue100(Orcamento orcamento)
        {
            foreach (Item item in orcamento.Itens)
            {
                if (item.Valor > 100) return true;
            }
            return false;
        }

    }
}
