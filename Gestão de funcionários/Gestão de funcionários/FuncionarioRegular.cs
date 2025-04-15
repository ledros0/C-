using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestão_de_funcionários
{
    public class FuncionarioRegular : Funcionario
    {
        public FuncionarioRegular(string nome, int idade, double salarioBase) : base(nome, idade, salarioBase)
        {
        }

        public override void MostrarFuncionario()
        {
            Console.WriteLine($"Funcionario: {nome} - {idade} anos - R${salarioBase}");
            CalcularSalario();
        }
        public override void CalcularSalario()
        {
            Console.WriteLine($"Salario Calculado: R${salarioBase}");
        }
    }
}
