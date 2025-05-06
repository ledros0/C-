using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
     public interface IEstocavel
    {
        void EstocarProduto(Produto item, int quantidade);
    }
}
