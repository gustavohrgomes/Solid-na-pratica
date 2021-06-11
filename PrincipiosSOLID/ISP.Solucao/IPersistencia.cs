using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Solucao
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();
    }
}
