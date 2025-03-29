using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cálculo_de_área_de_Triângulo__Quadrado_e__Círculo
{
    internal class Calculo
    {
        private double Base;
        private double Altura;
        private double Lado;
        private double Raio;
        private static double PI = 3.14;
        private double Area;

        public class Triangulo : Calculo
        {
            public Triangulo(double Base, double Altura)
            {
                this.Base = Base;
                this.Altura = Altura;

                Area = (Base * Altura)/2;

                Console.WriteLine($"A área do triângulo é {Area:N2}\n");
            }
        }
        public class Quadrado : Calculo 
        {
            public Quadrado(double Lado)
            {
                this.Lado = Lado;

                Area = Lado * Lado;

                Console.WriteLine($"A área do quadrado é {Area:N2}\n");
            }
        }
        public class Circulo : Calculo
        {
            public Circulo(double Raio)
            {
                this.Raio = Raio;

                Area = PI * (Raio * Raio);

                Console.WriteLine($"A área do círculo é {Area:N2}\n");
            }
        }
    }
}
