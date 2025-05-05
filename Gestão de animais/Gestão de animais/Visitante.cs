using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public abstract class Visitante 
    {
        public abstract void Visitar(List<Animal> listaAnimais);
    }
}
