using System;

namespace SOLID.Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaImpostoPais calc = new CalculaImpostoBrazil();
            calc.TotalRenda = 1000;
            calc.TotalDeducao = 100;

            CalcularImposto calcImp = new CalcularImposto();
            var valorTotalImposto = calcImp.Calcular(calc);
            Console.WriteLine($"Brasil {valorTotalImposto}");

            Console.ReadLine();
        }
    }
}
