using ResolvendoProblemas.Enums;

namespace ResolvendoProblemas.Interfaces
{
    public interface ICalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}
