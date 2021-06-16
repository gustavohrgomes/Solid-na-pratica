using System;

namespace SOLID.Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizzaria pizzaria = new Pizzaria(new PizzaFactory());
            pizzaria.CriarPizza("mussarela");
            pizzaria.CriarPizza("calabresa");
        }
    }
}
