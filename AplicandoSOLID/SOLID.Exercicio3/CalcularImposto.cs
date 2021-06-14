using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio3
{
    class CalcularImposto
    {
        public decimal Calcular(ICalculaImpostoPais icalc)
        {
            return icalc.CalcularValorImposto();
        }
    }
}
