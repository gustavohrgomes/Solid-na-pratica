using System;
using System.Collections.Generic;
using System.Text;

namespace LSP.Solucao
{
    class ContaPoupanca : Conta
    {
        public override double Saldo { get; set; }
        public void Saque(double valor)
        {
            if (Saldo > valor)
            {
                Saldo -= valor;
            }
        }
    }
}
