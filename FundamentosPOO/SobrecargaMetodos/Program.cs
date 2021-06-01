using System;

namespace SobrecargaMetodos
{
    class Program
    {
        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public double Somar(double numero1, int numero2)
        {
            return numero1 + numero2;
        }

        static public int Somar(int numero1, int numero2, int numero3)
        {
            return numero1 + numero2 + numero3;
        }

        static public double Somar(params int[] numeros)
        {
            var resultado = 0;
            foreach (var num in numeros)
                resultado += num;

            return resultado;
        }

        static void Main(string[] args)
        {
            var resultado1 = Somar(10, 20);
            var resultado2 = Program.Somar(10, 20, 30);

            var resultado3 = Somar(new int[] { 1, 2, 3, 4 });
            var resultado4 = Somar(1, 2, 3, 4);

            Console.WriteLine();
        }
    }
}
