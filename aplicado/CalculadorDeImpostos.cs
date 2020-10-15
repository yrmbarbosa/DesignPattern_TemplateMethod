using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class CalculadorDeImpostos
    {
        public double CalculaImposto(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);                        
        }
    }
}
