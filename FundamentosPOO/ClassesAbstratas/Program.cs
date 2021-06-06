using System;

namespace ClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado quadrado = new Quadrado();
            Console.WriteLine(quadrado.Descricao());

            Console.WriteLine("Informe a cor da figura");
            quadrado.Cor = Console.ReadLine();

            Console.WriteLine("Informe o lado do quadrado");
            quadrado.Lado = Convert.ToInt32(Console.ReadLine());

            quadrado.CalcularArea();
            quadrado.CalcularPerimetro();

            Console.WriteLine($"A área do quadrado é : {quadrado.Area} m2");
            Console.WriteLine($"O perímetro do quadrado é {quadrado.Perimetro} m ");
            Console.WriteLine($"O quadrado tem a cor : {quadrado.Cor}");
        }
    }
}
