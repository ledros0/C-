using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestão_de_funcionarios
{
    public class FuncionarioRegular : Funcionario
    {
        private double salarioFixo { get; set; }

        public FuncionarioRegular(string nome, int idade, double salarioBase) : base (nome, idade, salarioBase) 
        {
            this.nome = nome;
            this.idade = idade;
            this.salarioFixo = salarioBase;

            CalcularSalario(salarioFixo);
        }
    }
}
