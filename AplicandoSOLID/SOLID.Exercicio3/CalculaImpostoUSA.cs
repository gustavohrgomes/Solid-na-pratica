using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio3
{
    class CalculaImpostoUSA : ICalculaImpostoPais
    {
        public decimal TotalRenda { get; set; }
        public decimal TotalDeducao { get; set; }

        public decimal CalcularValorImposto()
        {
            decimal valorbase = TotalRenda - TotalDeducao;
            return valorbase * 50 / 100;
        }
    }
}
