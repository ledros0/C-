using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_17_02
{
    internal class Carro
    {
        public string cor;
        public int velocidade;

        public void andar()
        {
            Console.WriteLine($"O carro {cor} andou");
        }

        public void acelerar(int aceleracao)
        {
            velocidade += aceleracao;
        }
    }
}
