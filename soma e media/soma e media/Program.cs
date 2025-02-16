﻿static int Soma(int[] array)
{
    int soma = 0;
    foreach (int numeros in array)
    {
        soma += numeros;

    }
    return soma;
}

static double Média(int soma, int tamanhoTotal)
{
    return (double)soma / tamanhoTotal;
}

Console.WriteLine("Digite um número de 3 a 10 para a quantidade de números a serem pegos");
string Numero = Console.ReadLine();

int[] array;

int numeroConvertido = Convert.ToInt32(Numero);

switch (Numero)
{
    case "3":
    case "4":
    case "5":
    case "6":
    case "7":
    case "8":
    case "9":
    case "10":
        array = new int[numeroConvertido];
        break;


    default:
        Console.WriteLine("Número inválido, tente outro");
        return;
}

for (int i = 0; i < numeroConvertido; i++)
{
    Console.WriteLine($"Digite o {i + 1}º número");
    string valorDado = Console.ReadLine();
    array[i] = Convert.ToInt32(valorDado);

    int resultadoSoma = Soma(array);
    double resultadoMedia = Média(resultadoSoma, numeroConvertido);

    if (i == numeroConvertido - 1)
    {
        Console.WriteLine($"A soma dos números digitados é {resultadoSoma} e a sua média dada pelos números é {resultadoMedia} ");
        break;
    }
}