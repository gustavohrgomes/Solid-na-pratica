using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Violacao
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

        // Classe cadastrar produto não precisa enviar nenhum email.
        public void EnviarEmail()
        {
            throw new NotImplementedException();
        }
    }
}
