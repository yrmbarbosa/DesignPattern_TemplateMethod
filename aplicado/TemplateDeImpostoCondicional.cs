using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (DeveUsarMaximaTaxa(orcamento))
            {
                return MaximaTaxa(orcamento);
            }
            return MinimaTaxa(orcamento);
        }

        public abstract bool DeveUsarMaximaTaxa(Orcamento orcamento);
        public abstract double MaximaTaxa(Orcamento orcamento);
        public abstract double MinimaTaxa(Orcamento orcamento);

    }
}
