using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public class VisitanteLento : Visitante
    {
        public override void Visitar(List<Animal> listaAnimais)
        {
            Console.WriteLine("O visitante viu todos os animais, e eram a(o): ");

            for (int i = 0; i <= listaAnimais.Count; i++)
            {
                Console.WriteLine($"{listaAnimais[i].nome}");
            }
        }
    }
}
