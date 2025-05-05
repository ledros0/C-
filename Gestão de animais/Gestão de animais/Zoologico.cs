using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public class Zoologico
    {
        private readonly List <Animal> animais = new List <Animal> ();

        public void AdicionarAnimal(Animal novoAnimal)
        {
            if (animais.Contains(novoAnimal))
            {
                Console.WriteLine("Esse animal já está cadastrado");
                return;
            }

            animais.Add(novoAnimal);
        }

        public void RemoverAnimal(int colocacao) 
        {
            Console.WriteLine($"{animais[colocacao].nome} foi retirado(a) do zoologico\n");
            animais.RemoveAt(colocacao);
        }

        public void VerAnimal(int num)
        {
            animais[num].ExibirInformacoes();
        }
        public void QuantidadeAnimais()
        {
            int quantidade = animais.Count;
            Console.Write($"Tem {quantidade} animal(is) diferentes no zoologico:");
            for (int i = 0; i < animais.Count; i++)
            {
                Console.Write($"\n{animais[i].nome}");
            }
        }
    }
}
