using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class PIS : TemplateDeImpostoCondicional
    {

        public override bool DeveUsarMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
