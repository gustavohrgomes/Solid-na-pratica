using System;

namespace ResolvendoProblemas
{
    class GerenciadorDeDesconto
    {
        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE)
                ? (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100
                : (decimal)tempoDeContaEmAnos / 100;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    precoAposDesconto = precoProduto;
                    break;
                case StatusContaCliente.ClienteComum:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                case StatusContaCliente.ClienteEspecial:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                case StatusContaCliente.ClienteVip:
                    precoAposDesconto = (precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto));
                    precoAposDesconto = precoAposDesconto - (descontoPorFidelidade * precoAposDesconto);
                    break;
                default:
                    throw new ArgumentException("Status do cliente não pode estar vazio.");
            }

            return precoAposDesconto;
        }
    }
}
