using System;

namespace ParametrosOpcionais
{
    class Program
    {
        static public int Somar(int numero1, int numero2 = 0, int numero3 = 0, int numero4 = 0)
        {
            return numero1 + numero2 + numero3 + numero4;
        }
        static void Main(string[] args)
        {
            var resultado1 = Somar(10);
            var resultado2 = Somar(10, 20);
            var resultado3 = Somar(10, 20, 30);
            var resultado4 = Somar(10, 20, 30, 40);

            Console.WriteLine(resultado1);
            Console.WriteLine(resultado2);
            Console.WriteLine(resultado3);
            Console.WriteLine(resultado4);
        }
    }
}
