using System.Collections.Generic;
using Cálculo_de_área_de_Triângulo__Quadrado_e__Círculo;

Console.WriteLine("Digite as especificações do triângulo. (Base e Altura)");
double BaseT = Convert.ToDouble(Console.ReadLine());
double AlturaT = Convert.ToDouble(Console.ReadLine());
var tri = new Calculo.Triangulo(BaseT, AlturaT);

Console.WriteLine("Digite as especificações do quadrado. (Tamanho do lado)");
double Lado = Convert.ToDouble(Console.ReadLine());
var qua = new Calculo.Quadrado(Lado);

Console.WriteLine("Digite as especificações do quadrado. (Raio)");
double Raio = Convert.ToDouble(Console.ReadLine());
var cir = new Calculo.Circulo(Raio);