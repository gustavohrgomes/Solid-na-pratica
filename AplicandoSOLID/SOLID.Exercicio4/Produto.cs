using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio4
{
    public abstract class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        protected IPromocao _promocao;

        public Produto(IPromocao promocao)
        {
            _promocao = promocao;
        }

        public double DescontoPromocao()
        {
            return _promocao.Desconto();
        }

        public double PrecoVenda()
        {
            return Preco - (Preco * DescontoPromocao());
        }
    }
}
