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
        public string Tipo {  get;  }
        public string Tamanho { get; }

        public Roupa(string tipo, string tamanho, double preco, string info) : base(preco, info, "Roupa")
        {
            this.Tipo = tipo;
            this.Tamanho = tamanho;
        }
        public override string NomeProduto() => Tipo;
        public override void CalcularPreco(Produto item, double quantidade)
        {
            item.Preco *= quantidade;
            Console.WriteLine(item.Preco);
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"{Tipo} - {Tamanho} - {Preco}");
        }
    }
}
