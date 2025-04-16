using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_figura_geométrica
{
    public class Quadrado : FiguraGeometrica, IDesenhar
    {
        private double lado {  get; set; }

        public Quadrado(double lado)
        {
            this.lado = lado;
        }


        public override void CalcularArea()
        {
            double area = lado * lado;
            Console.WriteLine($"A area do Quadrado é: {area}cm");
        }

        public override void CalcularPerimetro()
        {
            double perimetro = lado * 4;
            Console.WriteLine($"O perimetro do Quadrado é: {perimetro}cm");
        }

        public void Desenhar()
        {
            int size = (int)lado;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                        Console.Write("* ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }
    }
}
