using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public abstract class Loja
    {
        public string marca {  get; set; }

        public abstract void VenderProduto(Produto item);
        public abstract void VenderProduto(Produto item, int quantidade);
    }
}
