using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestão_de_funcionarios
{
    public class Gerente : Funcionario
    {
        private double Salariofixo {  get; set; }
        private double Bonificacao { get; 
            set 
            {
                value = 142/100;
            } 
        }

        public Gerente(string nome, int idade, double salarioBase) : base(nome, idade, salarioBase)
        {
            this.nome = nome;
            this.idade = idade;
            this.salarioBase = Salariofixo;
        }

        public override void CalcularSalario(double salario)
        {
            base.CalcularSalario(salario);
            Console.WriteLine()

        }
    }
}
