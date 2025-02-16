using System.Collections.Generic;

List<double> ListaDeNotas = new List<double>();

double média = 0;
Console.WriteLine("Digite as 5 notas de um aluno.");
for (int i = 0; i < 5; i++)
{
    string notas = Console.ReadLine();
    double notasDouble = double.Parse(notas);

    ListaDeNotas.Add(notasDouble);
}

foreach (double notasDouble in ListaDeNotas)
{
    média += notasDouble; 
    
}
média = média / 5;
Console.WriteLine($"A média do aluno foi = {média:F1}");