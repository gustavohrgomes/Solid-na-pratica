using System;
using ResolvendoProblemas.Enums;
using ResolvendoProblemas.Interfaces;
using ResolvendoProblemas.Clientes;

namespace ResolvendoProblemas
{
    class GerenciadorDeDesconto
    {
        private readonly ICalculaDescontoFidelidade _descontoFidelidade;

        public GerenciadorDeDesconto(ICalculaDescontoFidelidade descontoFidelidade)
        {
            _descontoFidelidade = descontoFidelidade;
        }

        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = new ClienteNaoRegistrado().AplicarDescontoStatusConta(precoProduto);
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = new ClienteComum().AplicarDescontoStatusConta(precoProduto);
                    precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = new ClienteEspecial().AplicarDescontoStatusConta(precoProduto);
                    precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
                    break;
                case StatusContaCliente.ClienteVip:
                    precoAposDesconto = new ClienteVip().AplicarDescontoStatusConta(precoProduto);
                    precoAposDesconto = _descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);
                    break;
                default:
                    throw new ArgumentException("Status do cliente não pode estar vazio.");
            }

            return precoAposDesconto;
        }
    }
}
