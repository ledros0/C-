using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cadastrar_aluno_em_disciplina
{
    internal class Cadastro
    {
        public string nome = null;
        internal int notaAlg = 5, notaCalculo = 7;

        public void VerificarNotas(double[] NotafinalAlg, double[] NotafinalCalc)
        {
            double alg = 0;
            double calc = 0;

            for (int i = 0; i < 2; i++)
            { 
                   alg += NotafinalAlg[i];
                   calc += NotafinalCalc[i]; 

                while (i == 1)
                {
                    alg = alg / 2;
                    calc = calc / 2;

                    if (alg < 5)
                    {
                        Console.WriteLine($"\n{nome} não passou em algoritmos");
                    }
                    else
                    {
                        Console.WriteLine($"\n{nome} foi aprovado em algoritmos");
                    }
                    Console.WriteLine($"Com a média: {alg:F2}\n");

                    if (calc < 7)
                    {
                        Console.WriteLine($"{nome} não foi aprovado em calculo");
                    }
                    else
                    {
                        Console.WriteLine($"{nome} foi aprovado em calculo");
                    }
                    Console.WriteLine($"Com a média: {calc:F2}\n");
                    break;
                }
            }
        }
    }
}
