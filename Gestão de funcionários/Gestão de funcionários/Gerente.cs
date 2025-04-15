using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_funcionários
{
    public class Gerente : Funcionario, IAumentoSalario
    {
        private double Bonificacao { get; } = 350;

        public Gerente(string nome, int idade, double salarioBase) : base(nome, idade, salarioBase)
        {
        }

        public override void MostrarFuncionario()
        {
            Console.WriteLine($"Gerente: {nome} - {idade} anos - R${salarioBase}");
            CalcularSalario();
        }
        public override void CalcularSalario()
        {
            salarioBase += Bonificacao;
            Console.WriteLine($"Salário com bonificação: R${salarioBase}");
        }

        public void AumentarSalario()
        {
            Console.WriteLine("Digite a quantidade de aumento que você quer no salário do gerente.");
            double mudanca = Convert.ToDouble(Console.ReadLine());
            salarioBase += mudanca;
            MostrarFuncionario();
        }

    }
}
