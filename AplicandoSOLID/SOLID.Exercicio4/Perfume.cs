using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio4
{
    public class Perfume : Produto
    {
        public Perfume(IPromocao promocao) : base(promocao)
        {
        }
    }
}
