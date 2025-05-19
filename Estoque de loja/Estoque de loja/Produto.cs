using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public abstract class Produto
    {
        public double Preco { get; set; }
        public string Info { get; set; }
        public string TipoProduto { get; set; }
        public Produto(double preco, string info, string tipoProduto)
        {
            this.Preco = preco;
            this.Info = info;
            this.TipoProduto = tipoProduto;
        }
        public abstract string NomeProduto();

        public abstract void CalcularPreco(Produto item, double quantidade);
        public abstract void ExibirInformacoes();
    }
}
