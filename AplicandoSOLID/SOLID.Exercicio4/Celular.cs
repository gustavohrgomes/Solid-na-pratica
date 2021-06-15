using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio4
{
    public class Celular : Produto
    {
        public Celular(IPromocao promocao) : base(promocao)
        {
        }
    }
}
