using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblemas.Interfaces
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal precoProduto, int tempoDeContaEmAnos);
    }
}
