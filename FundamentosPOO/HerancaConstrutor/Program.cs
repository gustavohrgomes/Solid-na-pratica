using System;

namespace HerancaConstrutor
{
    class Veiculo
    {
        private string _numeroChassis;


        public Veiculo()
        {
            Console.WriteLine("Inicializando veiculo.");
        }
        public Veiculo(string numeroChassis)
        {
            _numeroChassis = numeroChassis;
            Console.WriteLine("Inicializando veiculo: " + numeroChassis);
        }

        public virtual void Teste()
        {
            Console.WriteLine("Acessei teste");
        }
    }

    class Carro : Veiculo 
    {
        public Carro()
        {
            Console.WriteLine("Inicializando carro.");
        }

        public Carro(string numeroChassis) : base(numeroChassis)
        {
            Console.WriteLine("Inicializando carro: " + numeroChassis);
        }

        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("Sobrescrevi teste");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            var carro = new Carro("123456");
            carro.Teste();
        }
    }
}
