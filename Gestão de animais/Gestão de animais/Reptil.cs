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

        public Reptil(string especie, string nome, string comprimento, string habitat) : base(especie, nome)
        {
            this.nome = nome;
            this.comprimento = comprimento;
            this.habitat = habitat;
            this.Especie = especie;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("rebt");
        }

        public override void Movimentar()
        {

        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}\nComprimeto: {comprimento}\nHabitat: {habitat}\n");
        }
    }
}
