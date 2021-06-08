using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrataXInterface
{
    abstract class Figura
    {
        protected string Nome { get; set; }

        public Figura(string nome)
        {
            Nome = nome;
        }

        public abstract void Desenhar();

        public abstract void Identificar();

        public void Duplicar()
        {
            Console.WriteLine("Duplicando...");
        }
    }
}
