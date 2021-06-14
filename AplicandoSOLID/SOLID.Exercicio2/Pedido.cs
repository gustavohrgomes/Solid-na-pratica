﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Exercicio2
{
    class Pedido
    {
        private ConsoleLogger log = new ConsoleLogger();
        public virtual void AdicionarPedido()
        {
            try
            {
                //código para validar e incluir pedido
                log.Registrar($"Pedido Incluido em :  {DateTime.Now}");
            }
            catch (Exception ex)
            {
                log.Registrar($"{ex} - {DateTime.Now}");
            }
        }
    }
}
