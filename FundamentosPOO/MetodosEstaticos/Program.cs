using System;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adição: " + Calculadora.Somar(38, 24));
            Console.WriteLine("Subtração: " + Calculadora.Subtrair(38, 24));
        }
    }
}
