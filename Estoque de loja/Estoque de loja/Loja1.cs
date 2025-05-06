using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public class Loja1 : Loja, IEstocavel
    {
        public Dictionary <Produto, int> Produtos = new Dictionary <Produto, int>();

        public void EstocarProduto(Produto item, int quantidade)
        {
            Produtos.Add(item, quantidade);
        }
    }
}
