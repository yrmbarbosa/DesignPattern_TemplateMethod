using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace nao_aplicado
{
    public class COFINS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && TemItemComValorMaiorQue100(orcamento))
            {
                return orcamento.Valor * 0.1;
            }
            return orcamento.Valor * 0.6;
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
