using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transações_bancárias
{
    public class ContaPoupanca : ContaBancaria, IMovimentacaoConta
    {
        private double taxaJuros { get; } = 0.14;
        public ContaPoupanca(string nome, int numeroCel, int numRG, int CPF, double dinheiro) : base(nome, numeroCel, numRG, CPF, dinheiro)
        {
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine($"Você não tem essa quantia na conta, tem apenas R${Saldo}\n Digite outro valor.");
                double NovoValor = Convert.ToDouble(Console.ReadLine());
                Sacar(NovoValor);
            }

            else
            {
                Saldo = Saldo - valor;
                Console.WriteLine($"Valor retirado... Valor atual: R${Saldo:F2}");
            }
        }
        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine($"Valor recebido: R${valor:F2}\nValor atual: R${Saldo:F2}");
            CalcularJuros();
        }

        public override void CalcularJuros()
        {
            Saldo = Saldo - (Saldo * taxaJuros);
            Console.WriteLine($"Deu win! Valor atual: R${Saldo:F2}\n");
        }
    }
}
