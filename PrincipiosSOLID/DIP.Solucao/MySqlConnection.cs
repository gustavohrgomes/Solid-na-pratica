using System;

namespace DIP.Solucao
{
    class MySqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com MySql");
        }
    }
}
