using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_funcionários
{
    public class Diretor : Funcionario, IAumentoSalario
    {
        private double LucroEmpresarial { get; } = 1.34;

        public Diretor (string nome, int idade, double salarioBase) : base (nome, idade, salarioBase) 
        {
        }

        public override void MostrarFuncionario()
        {
            Console.WriteLine($"Diretor: {nome} - {idade} anos - R${salarioBase}");
            CalcularSalario();
        }
        public override void CalcularSalario()
        {
            salarioBase = salarioBase * LucroEmpresarial;
            Console.WriteLine($"Salario Com o Lucro empresarial: R${salarioBase}");
        }

        public void AumentarSalario()
        {
            Console.WriteLine("Quanto você vai pegar do dinheiro dos outros, chefe?");
            double mudanca = Convert.ToDouble(Console.ReadLine());
            salarioBase += mudanca;
            MostrarFuncionario();
        }
    }
}
