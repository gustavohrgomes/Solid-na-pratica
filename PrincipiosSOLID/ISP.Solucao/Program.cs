using System;

namespace ISP.Solucao
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new CadastrarCliente();
            cliente.ValidarDados();
            cliente.SalvarDataBase();
            cliente.EnviarEmail();

            Console.WriteLine();

            var produto = new CadastrarProduto();
            produto.ValidarDados();
            produto.SalvarDataBase();
        }
    }
}
