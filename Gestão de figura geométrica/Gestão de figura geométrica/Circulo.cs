using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_figura_geométrica
{
    public class Circulo : FiguraGeometrica, IDesenhar
    {

        private double Pi { get; } = 3.14;
        private double Raio { get; set; }


        public Circulo(double raio)
        {
            this.Raio = raio;
        }


        public override void CalcularArea()
        {
            double area = Pi * Raio;
            Console.WriteLine($"A area do Circulo é: {area}cm");

        }

        public override void CalcularPerimetro()
        {
            double perimetro = 2 * (Pi * Raio);
            Console.WriteLine($"O perimetro do Circulo é: {perimetro}cm");
        }

        public void Desenhar()
        {
            Console.WriteLine("\nDesenhando um Círculo:");
            double radius = Raio;
            double thickness = 0.4;
            double rIn = radius - thickness, rOut = radius + thickness;

            for (double y = radius; y >= -radius; --y)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + y * y;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
