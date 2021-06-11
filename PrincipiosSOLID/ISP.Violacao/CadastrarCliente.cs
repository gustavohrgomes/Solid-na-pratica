using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Violacao
{
    class CadastrarCliente : IPersistencia
    {
        public void ValidarDados()
        {
            Console.WriteLine("Cliente: Validando dados.");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Cliente: Salvando dados.");
        }

        public void EnviarEmail()
        {
            Console.WriteLine("Cliente: Enviando Email.");
        }
    }
}
