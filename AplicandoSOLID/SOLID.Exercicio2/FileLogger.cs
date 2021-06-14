using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.Exercicio2
{
    class FileLogger : ILogger
    {
        public void Registrar(string message)
        {
            File.WriteAllText(@"c:\www\LogOcorrencias.txt", message);
        }
    }
}
