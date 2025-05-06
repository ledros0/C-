using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public class Eletronico : Produto
    {
        public string marca {  get; }
        public string modelo { get; }

        public Eletronico(string marca, string modelo, double preco, string info) : base(preco, info) 
        {
            this.marca = marca;
            this.modelo = modelo;
            this.preco = preco;
            this.info = info;
        }
        public override void CalcularPreco(Produto item)
        {
            
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"{marca} - {modelo} - {preco}");
        }
    }
}
