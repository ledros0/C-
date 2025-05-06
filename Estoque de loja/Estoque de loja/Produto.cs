using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public abstract class Produto
    {
        public double preco { get; set; }
        public string info { get; set; }
        public Produto(double preco, string info)
        {
            this.preco = preco;
            this.info = info;
        }

        public abstract void CalcularPreco(Produto compra);
        public abstract void ExibirInformacoes();
    }
}
