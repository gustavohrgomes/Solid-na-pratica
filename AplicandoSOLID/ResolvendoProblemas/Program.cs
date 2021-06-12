using ResolvendoProblemas.Enums;
using ResolvendoProblemas.Interfaces;
using System;

namespace ResolvendoProblemas
{
    class Program
    {
        static void Main(string[] args)
        {
            ICalculaDescontoFidelidade descontoFidelidade = new CalculaDescontoFidelidade();
            ICalculaDescontoStatusContaFactory descontoStatusConta = new CalculaDescontoStatusContaFactory();

            GerenciadorDeDesconto gerenciadorDesconto = new GerenciadorDeDesconto(descontoFidelidade, descontoStatusConta);

            Console.WriteLine("Valor da compra 1000 e fidelidade 10 anos (5%)\n");

            var resultado = gerenciadorDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado}");

            var resultado1 = gerenciadorDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Cliente tipo 3 o valor do desconto é de : {resultado1}");

            var resultado2 = gerenciadorDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 10);
            Console.WriteLine($"Cliente tipo 4 o valor do desconto é de : {resultado2}\n");

            Console.WriteLine("Valor da compra 1000 e fidelidade 4 anos (4%)\n");
            var resultado3 = gerenciadorDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteComum, 4);
            Console.WriteLine($"Cliente tipo 2, 10 anos fidelidade,  = {resultado3}");

            var resultado4 = gerenciadorDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteEspecial, 4);
            Console.WriteLine($"Para Cliente tipo 3 o valor do desconto é de : {resultado4}");

            var resultado5 = gerenciadorDesconto.AplicarDesconto(1000, StatusContaCliente.ClienteVip, 4);
            Console.WriteLine($"Para Cliente tipo 4 o valor do desconto é de : {resultado5}");

            Console.ReadLine();
        }
    }
}
