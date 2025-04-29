using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Transações_bancárias
{
     public abstract class ContaBancaria
    {
        protected string Nome { get; set; }
        protected int NumeroCelular { get; set; }
        protected int NumRG { get; set; }
        protected int CPF { get; set; }
        protected double Saldo { get; set; }

        public ContaBancaria(string nome, int numeroCel, int numRG, int CPF, double dinheiro)
        {
            this.Nome = nome;
            this.NumeroCelular = numeroCel;
            this.NumRG = numRG;
            this.CPF = CPF;
            this.Saldo = dinheiro;
        }
        public abstract void CalcularJuros();
    }
}
