using ResolvendoProblemas.Interfaces;

namespace ResolvendoProblemas.Clientes
{
    public class ClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal precoProduto)
        {
            return precoProduto - (Constantes.DESCONTO_CLIENTE_ESPECIAL * precoProduto);
        }
    }
}
