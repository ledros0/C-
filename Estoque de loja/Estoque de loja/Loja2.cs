using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    internal class Loja2 : Loja, IEstocavel2
    {
        public List<Produto> produtos = new List<Produto>();

       public void EstocarProduto(Produto item)
        {
            produtos.Add(item);
        }
    }
}
