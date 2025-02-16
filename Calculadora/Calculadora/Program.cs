
double Adição (double numero1, double numero2)
{
    return numero1 + numero2;
}
double Subtração (double numero1, double numero2)
{
    return numero1 - numero2;
}
double Multiplicação (double numero1, double numero2)
{
    return numero1 * numero2;
}
double Divisão (double numero1, double numero2)
{
    return numero1 / numero2;
}
double RestoDaDivisão(double numero1, double numero2)
{
    return numero1 % numero2;
}
double Potenciação (double baseNumero, double expoente)
{
    if (expoente == 0)
        return 1; 

    if (baseNumero == 0)
        return 0; 

    double resultado = 1;
    for (int i = 0; i < Math.Abs(expoente); i++)
    {
        resultado *= baseNumero; 
    }
    return resultado;
}

Console.WriteLine("Digite o número que você quer usar");
string primeiroNumero = Console.ReadLine();
double numero1 = Convert.ToDouble(primeiroNumero);

string segundoNumero;

double numero2;

double resultado;

Console.WriteLine("Para usar a calculadora utilize esses números:\n 1 - Soma \n 2 - Substração \n 3 - Multiplicação \n 4 - Divisão \n 5 - Resto da divisão \n 6 - Potenciação \n 0 - sair");
string numeroCalculadora = Console.ReadLine();

int numeroErrado = 0;



switch (numeroCalculadora)
{
    case "1":
        Console.WriteLine("Digite o próximo número");
        segundoNumero = Console.ReadLine();
        numero2 = Convert.ToDouble(segundoNumero);
        resultado = Adição(numero1, numero2);
        Console.WriteLine($"O Resultado é: {resultado}");
        break;

    case "2":
        Console.WriteLine("Digite o próximo número");
        segundoNumero = Console.ReadLine();
        numero2 = Convert.ToDouble(segundoNumero);
        resultado = Subtração(numero1, numero2);
        Console.WriteLine($"O Resultado é: {resultado}");
        break;

    case "3":
        Console.WriteLine("Digite o próximo número");
        segundoNumero = Console.ReadLine();
        numero2 = Convert.ToDouble(segundoNumero);
        resultado = Multiplicação(numero1, numero2);
        Console.WriteLine($"O Resultado é: {resultado}");
        break;

    case "4":
        Console.WriteLine("Digite o próximo número");
        segundoNumero = Console.ReadLine();
        numero2 = Convert.ToDouble(segundoNumero);
        if (numero2 == 0)
        {
            Console.WriteLine("Não é possível dividir por zero");
        }
        resultado = Divisão(numero1, numero2);
        Console.WriteLine($"O Resultado é: {resultado}");
        break;

    case "5":
        Console.WriteLine("Digite o próximo número");
        segundoNumero = Console.ReadLine();
        numero2 = Convert.ToDouble(segundoNumero);
        resultado = RestoDaDivisão(numero1, numero2);
        Console.WriteLine($"O Resultado é: {resultado}");
        break;

    case "6":
        Console.WriteLine("Digite o próximo número");
        segundoNumero = Console.ReadLine();
        numero2 = Convert.ToDouble(segundoNumero);
        resultado = Potenciação(numero1, numero2);
        Console.WriteLine($"O Resultado é: {resultado}");
        break;

    case "0":
        Console.WriteLine("Fim do programa.");
        break;
        
}