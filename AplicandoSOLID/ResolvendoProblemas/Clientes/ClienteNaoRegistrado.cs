using ResolvendoProblemas.Interfaces;

namespace ResolvendoProblemas.Clientes
{
    public class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal precoProduto)
        {
            return precoProduto;
        }
    }
}
