using System;

namespace Heranca
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            Console.WriteLine("Contrutor da classe Conta");
        }

        // Caso o método a ser sobreescrito pela classe derivada não possua a keyword
        // virtual, o próprio compilador irá esconder o método da classe base,
        // dando preferência para o método da classe derivada.
        protected virtual void GetSaldo()
        {
            Console.WriteLine("Saldo 99,99");
        }
    }

    class ContaPoupança : Conta
    {
        public double JurosMensais { get; set; }

        // alternativa caso a classe base não possua a keyword virtual para sobreescrita
        // e queira ocultar o método da classe base.
        // protected new void GetSaldo()
        protected override void GetSaldo()
        {
            Console.WriteLine("Saldo 88,88");
        }

        static void Main(string[] args)
        {
            ContaPoupança conta = new ContaPoupança();

            conta.Numero = 100;
            conta.Saldo = 99.99;
            conta.GetSaldo();
        }
    }
}
