using System;

namespace ModeloDominio
{
    class Program
    {
        static void Main(string[] args)
        {
            ClienteRico cliente = new ClienteRico(-1, "", null);

            Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");
        }

        private static void ClienteAnemico()
        {
            ClienteAnemico cliente = new ClienteAnemico();
            cliente.Id = -1;
            cliente.Nome = "";
            cliente.Endereco = null;

            Console.WriteLine($"{cliente.Id} {cliente.Nome} {cliente.Endereco}");
        }
    }
}
