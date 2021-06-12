using ResolvendoProblemas.Interfaces;

namespace ResolvendoProblemas
{
    class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal precoProduto, int tempoDeContaEmAnos)
        {
            decimal descontoPorFidelidade = (tempoDeContaEmAnos > Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE)
                ? (decimal)Constantes.DESCONTO_MAXIMO_POR_FIDELIDADE / 100
                : (decimal)tempoDeContaEmAnos / 100;

            return precoProduto - (descontoPorFidelidade * precoProduto);
        }
    }
}
