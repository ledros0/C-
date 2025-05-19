using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public class Loja1 : Loja, IEstocavel
    {
        private Dictionary<string, int> Produtos;
        public string NomeLoja { get; }

        public Loja1(string marca) : base(marca) 
        {
            Produtos = new Dictionary<string, int>();
            this.NomeLoja = marca;
        }

        public void EstocarProduto(Produto item)
        {
            Console.WriteLine("Quantos produtos você quer estocar?");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                if (Produtos.ContainsKey(item.TipoProduto))
                {
                    Produtos[item.TipoProduto]++;
                }
                else
                {
                    Produtos[item.TipoProduto] = 1;
                }
            }
        }

        public override void VenderProduto(Produto item)
        {
            Console.WriteLine("Qual a quantidade que você quer deste produto?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            VenderProduto(item, quantidade);
        }

        public override void VenderProduto(Produto item, int quantidade)
        {
            if (Produtos.ContainsKey(item.TipoProduto) && Produtos[item.TipoProduto] >= quantidade)
            {
                Produtos[item.TipoProduto] -= quantidade;
                Console.Write($"Está sendo vendido {quantidade} unidade(s) de {item.NomeProduto()} na {NomeLoja}. O preco foi de R$");
                item.CalcularPreco(item, quantidade);
            }
            else
            {
                Console.WriteLine($"Não tem {quantidade} {item.NomeProduto()}(s) na loja, tem apenas {Produtos[item.TipoProduto]}");
                VenderProduto(item);
            }
        }
    }
}
