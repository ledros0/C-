using System.Collections.Generic;
using Sistema_de_ingressos;
Random random = new Random();

var Ingresso = new Ingresso();
Ingresso.distribuicaoIngresso();
Ingresso.mostrarIngressos();

Console.WriteLine("\nBem vindo ao site! Quanto dinheiro você tem?\n");
int dinheiro = Convert.ToInt32(Console.ReadLine());
var Transacoes = new Transacoes();
Transacoes.Dinheiro(dinheiro);

Console.WriteLine("Qual tipo de ingresso você gostaria de comprar?");
string tipo = Console.ReadLine();
int quantidade = Convert.ToInt32(Console.ReadLine());
Transacoes.ComprarIngressos(tipo, quantidade);
/*while (dinheiro >= 40)
{

   Transacoes.ComprarIngressos(tipo, quantidade);
    tipo = Console.ReadLine();
    quantidade = Convert.ToInt32(Console.ReadLine);
}*/


