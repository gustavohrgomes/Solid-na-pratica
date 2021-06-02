using System;
using MetodosExtensao.Extensions;

namespace MetodosExtensao
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto1 = "curso";
            var texto2 = "testando 123";

            texto1 = texto1.CaixaAltaPrimeiraLetra();
            texto2 = texto2.CaixaAltaPrimeiraLetra();

            Console.WriteLine(texto1);
            Console.WriteLine(texto2);
        }
    }
}
