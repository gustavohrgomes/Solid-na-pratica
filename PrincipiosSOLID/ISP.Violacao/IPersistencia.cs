using System;
using System.Collections.Generic;
using System.Text;

namespace ISP.Violacao
{
    interface IPersistencia
    {
        void ValidarDados();
        void SalvarDataBase();
        void EnviarEmail();
    }
}
