using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public class Mamifero : Animal
    {
        public string corPelagem { get; }
        public string tipoAlimentacao { get; }

        public Mamifero(string especie,string nome, string corPelagem, string tipoAlimentacao) : base(especie, nome)
        {
            this.corPelagem = corPelagem;
            this.tipoAlimentacao = tipoAlimentacao;
            this.nome = nome;
            this.Especie = especie;
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Raw");
        }

        public override void Movimentar()
        {
            
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {nome}\nCor da pelagem: {corPelagem}\nTipo de alimentacao: {tipoAlimentacao}\n");
        }
    }
}
