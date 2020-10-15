using nao_aplicado;
using System;
using System.Collections.Generic;
using System.Text;

namespace nao_aplicado
{
    public class CalculadorDeImpostos
    {
        public double CalculaImposto(Orcamento orcamento, IImposto imposto)
        {
            return imposto.Calcular(orcamento);                        
        }
    }
}
