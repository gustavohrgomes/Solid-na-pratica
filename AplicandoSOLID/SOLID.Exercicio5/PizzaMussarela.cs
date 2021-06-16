using System;

namespace SOLID.Exercicio5
{
    public sealed class PizzaMussarela : Pizza
    {
        public PizzaMussarela(string nome) : base(nome)
        {
        }

        public override int AssarPizza()
        {
            var tempo = 25;
            Console.WriteLine($"Assando pizza de {Sabor} por {tempo} minutos");
            return tempo;
        }
    }
}
