using ResolvendoProblemas.Interfaces;

namespace ResolvendoProblemas.Clientes
{
    public class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal precoProduto)
        {
            return precoProduto - (Constantes.DESCONTO_CLIENTE_COMUM * precoProduto);
        }
    }
}
