using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public class Roupa : Produto
    {
        public string tipo {  get; set; }
        public string tamanho { get; set; }

        public Roupa(string tipo, string tamanho, double preco, string info) : base(preco, info)
        {
            this.tipo = tipo;
            this.tamanho = tamanho;
            this.preco = preco;
            this.info = info;
        }
        public override void CalcularPreco(Produto item)
        {

        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"{tipo} - {tamanho} - {preco}");
        }
    }
}
