using System;

namespace SOLID.Exercicio2
{
    class ConsoleLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}
