using System;
using System.Collections.Generic;
using System.Text;

namespace nao_aplicado
{
    public class PIS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor >= 500)
            {
                return orcamento.Valor * 0.07;
            }
            return orcamento.Valor * 0.05;
        }
    }
}
