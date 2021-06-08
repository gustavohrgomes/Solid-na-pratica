using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrataXInterface
{
    class Quadrado : Figura
    {
        public Quadrado(string nome) : base(nome)
        {
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando: {Nome}");
            Duplicar();
        }

        public override void Identificar()
        {
            Console.WriteLine($"Sou o: {Nome}");
        }
    }
}
