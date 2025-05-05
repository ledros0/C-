using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public class Reptil : Animal
    {
        public string comprimento {  get; }
        private string habitat {  get; }

        public Reptil(string especie, string nome, string som, string comprimento, string habitat) : base(especie, nome, som)
        {
            this.nome = nome;
            this.comprimento = comprimento;
            this.habitat = habitat;
            this.Especie = especie;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{som}\n");
        }

        public override void Movimentar()
        {
            Console.WriteLine("O animal pulou ou rastejou");
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}\nComprimeto: {comprimento}\nHabitat: {habitat}");
        }
    }
}
