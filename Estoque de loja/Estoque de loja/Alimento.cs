using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public class Alimento : Produto
    {
        public string nome { get; set; }
        public string dataValidade { get; set; }
        public Alimento(string nome, string dataValidade, double preco, string info) : base(preco, info) 
        {
            this.nome = nome;
            this.dataValidade = dataValidade;
            this.preco = preco;
            this.info = info;
        }
        public override void CalcularPreco(Produto item)
        {

        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"{nome} - {dataValidade} - {preco}");
        }

    }
}
