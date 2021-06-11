using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Solucao
{
    class ContaComum : Conta
    {
        public override double Saldo { get; set; }
        public void Saque(double valor)
        {
            Saldo -= valor;
        }
    }
}
