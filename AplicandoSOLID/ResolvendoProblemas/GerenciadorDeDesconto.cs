using System;
using ResolvendoProblemas.Enums;
using ResolvendoProblemas.Interfaces;
using ResolvendoProblemas.Clientes;

namespace ResolvendoProblemas
{
    class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade _descontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory _descontoStatusConta;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade, ICalculaDescontoStatusContaFactory descontoStatusConta)
        {
            _descontoFidelidade = descontoFidelidade;
            _descontoStatusConta = descontoStatusConta;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = _descontoStatusConta.GetCalculaDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(precoProduto);
            precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}
