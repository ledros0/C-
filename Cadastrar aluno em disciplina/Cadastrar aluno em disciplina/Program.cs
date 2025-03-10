using Cadastrar_aluno_em_disciplina;

Cadastro Aluno1 =  new Cadastro();
Aluno1.nome = "Renato Augusto";

double[] notaCalc = new double[2]; 
double[] notaAlg = new double[2];


Console.WriteLine("Digite as notas do aluno em Algoritmo");
for (int i = 0; i < 2; i++)
{
    notaAlg[i] = Convert.ToDouble(Console.ReadLine());

}

Console.WriteLine("Digite as notas do aluno em Calculo");
for (int i = 0; i < 2; i++)
{
    notaCalc[i] = Convert.ToDouble(Console.ReadLine());

}

Aluno1.VerificarNotas(notaAlg, notaCalc);