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
        public string Nome { get; }
        public string DataValidade { get; }
        public Alimento(string nome, string dataValidade, double preco, string info) : base(preco, info, "Alimento") 
        {
            this.Nome = nome;
            this.DataValidade = dataValidade;
        }
        public override string NomeProduto() => Nome;
        public override void CalcularPreco(Produto item, double quantidade)
        {
            item.Preco *= quantidade;
            Console.WriteLine(item.Preco);
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"{Nome} - {DataValidade} - {Preco}");
        }

    }
}
