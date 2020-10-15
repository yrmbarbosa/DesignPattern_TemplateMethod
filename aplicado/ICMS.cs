using System;
using System.Collections.Generic;
using System.Text;

namespace aplicado
{
    public class ICMS : IImposto
    {        
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}
