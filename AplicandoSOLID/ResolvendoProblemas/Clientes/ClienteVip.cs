using ResolvendoProblemas.Interfaces;

namespace ResolvendoProblemas.Clientes
{
    public class ClienteVip : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal precoProduto)
        {
            return precoProduto - (Constantes.DESCONTO_CLIENTE_VIP * precoProduto);
        }
    }
}
