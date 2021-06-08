﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrataXInterface
{
    class Triangulo : IFigura
    {
        public string Nome { get; set; }

        public Triangulo(string nome)
        {
            Nome = nome;
        }

        public void Desenhar()
        {
            Console.WriteLine($"Desenhando o: {Nome}");
        }

        public void Identificar()
        {
            Console.WriteLine($"Sou o: {Nome}");
        }

        public void Duplicar()
        {
            Console.WriteLine("Duplicando...");
        }
    }
}
