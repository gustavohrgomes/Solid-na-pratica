using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio3
{
    class CalculaImpostoArgentina : ICalculaImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorBase = TotalRenda - TotalDeducao;
            return valorBase * 40 / 100;
        }
    }
}
