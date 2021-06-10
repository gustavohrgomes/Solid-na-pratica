using System;
using System.Collections.Generic;
using System.Text;

namespace SRP_Aderente
{
    class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILogger logger;
        private EnviarEmail enviarEmail;

        public Pedido()
        {
            logger = new RegistraLog();
            enviarEmail = new EnviarEmail();
        }

        public void IncluirPedido()
        {
            try
            {
                logger.Info("Incluindo pedido.");
                enviarEmail.EmailFrom = "from@email.com";
                enviarEmail.EmailTo = "to@email.com";
                enviarEmail.EmailSubject = "Pedido";
                enviarEmail.EmailBody = "Pedido incluso";
                enviarEmail.Enviar();
            }
            catch (Exception ex)
            {
                logger.Info(ex.Message);
            }
        }
        public void DeletaPedido()
        {
            try
            {
                logger.Info("Removendo pedido.");
            }
            catch (Exception ex)
            {
                logger.Info(ex.Message);
            }
        }
    }
}
