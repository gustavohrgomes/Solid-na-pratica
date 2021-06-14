using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio2
{
    class Pedido
    {
        private readonly ILogger _logger;

        public Pedido(ILogger logger)
        {
            _logger = logger;
        }

        public virtual void AdicionarPedido()
        {
            try
            {
                //código para validar e incluir pedido
                _logger.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                _logger.Registrar($"{ex} - {DateTime.Now}");
            }
        }
    }
}
