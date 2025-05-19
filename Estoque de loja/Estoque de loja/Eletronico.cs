using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque_de_loja
{
    public class Eletronico : Produto
    {
        public string Marca {  get; }
        public string Modelo { get; }

        public Eletronico(string marca, string modelo, double preco, string info) : base(preco, info, "Eletronico") 
        {
            this.Marca = marca;
            this.Modelo = modelo;
        }

        public override string NomeProduto() => Modelo;
        public override void CalcularPreco(Produto item, double quantidade)
        {
            item.Preco *= quantidade;
            Console.Write(item.Preco);
        }
        public override void ExibirInformacoes()
        {
            Console.WriteLine($"{Marca} - {Modelo} - {Preco}");
        }
    }
}
