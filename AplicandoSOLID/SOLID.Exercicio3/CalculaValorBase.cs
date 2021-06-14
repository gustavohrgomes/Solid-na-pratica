using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio3
{
    class CalculaValorBase : ICalculaValorBase
    {
        public decimal Calcular(decimal valorDaRenda, decimal deducoesTotais)
        {
            return deducoesTotais - valorDaRenda;
        }
    }
}
