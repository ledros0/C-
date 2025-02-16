double calculoMedia(double[,] matriz)
{
    double resultado = 0;
    for (int i = 0; i < 5; i++)
    {
        for (int j = 0; j < 5; j++)
        {
            resultado += matriz[i,j];
        }
        resultado = resultado / 5;
        Console.WriteLine($"O {i+1}º aluno ficou com a média = {resultado:F1}\n");
        resultado = 0;
    }
    return 0;
}

double[,] matriz = new double[5, 5];
Random nota = new Random();


for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        matriz[i, j] = 0.5 + (10.0 - 0.5) * nota.NextDouble();
    }
}

calculoMedia(matriz);
