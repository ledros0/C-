using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public class VisitanteRapido : Visitante
    {
        public override void Visitar(List<Animal> listaAnimais)
        {
            Console.WriteLine("\n\nO visitante passou rápido e viu a(o): ");

            for (int i = 0; i <= listaAnimais.Count; i = i + 2) 
            {
                if (i > listaAnimais.Count - 1)
                {
                    break;
                }
                Console.WriteLine($"{listaAnimais[i].nome}");
            }
        }
    }
}
