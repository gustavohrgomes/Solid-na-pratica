using System;

namespace SOLID.Exercicio5
{
    public abstract class Pizza
    {
        public string Sabor { get; set; }

        public Pizza(string sabor)
        {
            Sabor = sabor;
        }
        public abstract int AssarPizza();
        public void EntregarPizza()
        {
            Console.WriteLine($"Entregar Pizza de {Sabor}");
        }
    }
}
