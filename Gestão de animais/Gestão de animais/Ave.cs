using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public class Ave : Animal
    {
        public string corPenas {  get; }
        public string tipoVoo {  get; }

        public Ave(string especie, string nome, string som, string tipoVoo, string corPenas) : base(especie, nome, som)
        {
            this.nome = nome;
            this.corPenas = corPenas;
            this.tipoVoo = tipoVoo;
            this.Especie = especie;
        }

        public override void EmitirSom()
        {
            Console.WriteLine($"{som}\n");
        }

        public override void Movimentar()
        {
            Console.WriteLine("O animal voou..");
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}\nCor das Penas: {corPenas}\nTipo de voo: {tipoVoo}");
        }
    }
}
