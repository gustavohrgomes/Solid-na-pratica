using System;

namespace SOLID.Exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto celular = new Celular(new PromocaoDiaMaes());
            celular.Nome = "Galaxy M31";
            celular.Preco = 1000.00;
            var precoCelular = celular.PrecoVenda();
            Console.WriteLine($"{celular.Nome} (20% Off): {precoCelular}");

            Produto perfume = new Perfume(new PromocaoDiaNamorados());
            perfume.Nome = "Chanel N°5";
            perfume.Preco = 500.00;
            var precoPerfume = perfume.PrecoVenda();
            Console.WriteLine($"{perfume.Nome} (10% Off): {precoPerfume}");
        }
    }
}
