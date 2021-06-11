using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Solucao
{
    class CadastrarProduto : IPersistencia
    {
        public void ValidarDados()
        {
            Console.WriteLine("Produto: Validando dados.");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Produto: Salvando dados.");
        }
    }
}
