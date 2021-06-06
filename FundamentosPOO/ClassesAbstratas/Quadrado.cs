using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAbstratas
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }

        public override void CalcularArea()
        {
            Area = Lado * Lado;
        }

        public override void CalcularPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}
