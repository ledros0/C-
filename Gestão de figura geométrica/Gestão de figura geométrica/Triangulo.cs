using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_figura_geométrica
{
    public class Triangulo : FiguraGeometrica, IDesenhar
    {
        private double CA { get; set; }
        private double CO { get; set; }
        private double HIPO { get; set; }

        public Triangulo (double CA, double CO, double HIPO)
        { 
          this.CA = CA;
          this.CO = CO;
          this.HIPO = HIPO;
        }

        public override void CalcularArea()
        {
            double area = (HIPO * CA) / 2;
            Console.WriteLine($"A area do Triangulo é: {area}cm");
        }
        public override void CalcularPerimetro()
        {
            double perimetro = CA + CO + HIPO;
            Console.WriteLine ($"O perimetro do Triangulo é: {perimetro}cm");
        }

        public void Desenhar()
        {
            int height = (int)(Math.Max(CA, Math.Max(CO, HIPO)) / 2);

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                    Console.Write(" ");

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    if (k == 1 || k == 2 * i - 1 || i == height)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}