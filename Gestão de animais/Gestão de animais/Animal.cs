using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_animais
{
    public abstract class Animal : IVisitavel
    {
        public string Especie {  get; set; }
        public string nome { get; set; }
        public string som {  get; set; }
        public Animal(string especie, string nome, string som) 
        {
            this.Especie = especie;
            this.nome = nome;
            this.som = som;
        }

        public abstract void EmitirSom();
        public abstract void Movimentar();
        public abstract void ExibirInformacoes();
    }
}
