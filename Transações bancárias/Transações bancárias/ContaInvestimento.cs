using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transações_bancárias
{
    public class ContaInvestimento : ContaBancaria, IMovimentacaoConta
    {
        private double rendimentoAnual { get; } = 0.80;

        public ContaInvestimento(string nome, int numeroCel, int numRG, int CPF, double dinheiro) : base(nome, numeroCel, numRG, CPF, dinheiro)
        {
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine($"Você não tem essa quantia na conta, tem apenas R${Saldo:F2}\n Digite outro valor.");
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
            Saldo = Saldo + (Saldo * rendimentoAnual);
            Console.WriteLine($"Seja taxado, valor restante: R${Saldo:F2}\n");
        }
    }
}
