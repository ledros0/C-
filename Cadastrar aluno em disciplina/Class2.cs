using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionario;

public class Funcionario
{
    public string Nome = null;
    public int CPF;
    public double Salario;

    public double CorrecaoSalario(double CorrecaoSalario)
    {
        double porcentagemCorrecao;
        double valorDescontado;
        double valorCorrigido;

        double SalarioLiquidoFuncionarios = 0;
        double DescontoTotalFuncionarios = 0;
        double Salariobruto = 0;

        if (CorrecaoSalario <= 2000)
        {
            Console.WriteLine($"Seu salário é de {CorrecaoSalario} R$");
        }
        else if (CorrecaoSalario >= 2000.01 && CorrecaoSalario <= 3000)
        {
            porcentagemCorrecao = 7.5;
            valorDescontado = (porcentagemCorrecao / 100) * CorrecaoSalario;
            valorCorrigido = (CorrecaoSalario - valorDescontado);
            Console.WriteLine($"Seu salário corrigo é de {valorCorrigido:F2} R$\n Foi descontado {porcentagemCorrecao}% dos {CorrecaoSalario:F2} R$\n");
        }
        else if (CorrecaoSalario >= 3000.1 && CorrecaoSalario <= 4000)
        {
            porcentagemCorrecao = 15;
            valorDescontado = (porcentagemCorrecao / 100) * CorrecaoSalario;
            valorCorrigido = (CorrecaoSalario - valorDescontado);
            Console.WriteLine($"Seu salário corrigo é de {valorCorrigido:F2} R$\nFoi descontado {porcentagemCorrecao}% dos {CorrecaoSalario:F2} R$\n");
        }
        else if (CorrecaoSalario >= 4000.1 && CorrecaoSalario <= 5000)
        {
            porcentagemCorrecao = 22.5;
            valorDescontado = (porcentagemCorrecao / 100) * CorrecaoSalario;
            valorCorrigido = (CorrecaoSalario - valorDescontado);
            Console.WriteLine($"Seu salário corrigo é de {valorCorrigido:F2} R$\nFoi descontado {porcentagemCorrecao}% dos {CorrecaoSalario:F2} R$\n");
        }
        else
        {
            porcentagemCorrecao = 27.5;
            valorDescontado = (porcentagemCorrecao / 100) * CorrecaoSalario;
            valorCorrigido = (CorrecaoSalario - valorDescontado);
            Console.WriteLine($"Seu salário corrigo é de {valorCorrigido:F2} R$\nFoi descontado {porcentagemCorrecao}% dos {CorrecaoSalario:F2} R$\n");
        }
        return 0;
    }
}