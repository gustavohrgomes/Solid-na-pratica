using ResolvendoProblemas.Clientes;
using ResolvendoProblemas.Enums;
using ResolvendoProblemas.Interfaces;
using System;

namespace ResolvendoProblemas
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta calculaDesconto;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    calculaDesconto = new ClienteNaoRegistrado();
                    break;
                case StatusContaCliente.ClienteComum:
                    calculaDesconto = new ClienteComum();
                    break;
                case StatusContaCliente.ClienteEspecial:
                    calculaDesconto = new ClienteEspecial();
                    break;
                case StatusContaCliente.ClienteVip:
                    calculaDesconto = new ClienteVip();
                    break;
                default:
                    throw new ArgumentException("Status do cliente não pode estar vazio.");
            }

            return calculaDesconto;
        }
    }
}
