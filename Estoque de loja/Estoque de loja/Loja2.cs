using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    internal class Loja2 : Loja, IEstocavel
    {
        public List<string> Produtos;
        public string NomeLoja { get; }
        public Loja2 (string marca) : base(marca)
        {
            Produtos = new List<string> ();
            this.NomeLoja = marca;
        }

       public void EstocarProduto(Produto item)
        {
            string itemConvertido = (item.NomeProduto());

           if (Produtos.Contains(itemConvertido))
            {
                Console.WriteLine("O produto escolhido foi guardado");
            }
           else
            {
                Console.WriteLine("Primeira aparição desse produto! Agora está armazenado");
                Produtos.Add(itemConvertido);
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
            Console.Write($"Está sendo vendido {quantidade} unidade(s) de {item.NomeProduto()} na {NomeLoja}. O preco foi de R$");
            item.CalcularPreco(item, quantidade);
        }
    }
}
