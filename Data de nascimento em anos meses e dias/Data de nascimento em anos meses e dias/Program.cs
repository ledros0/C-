using static System.Runtime.InteropServices.JavaScript.JSType;

DateTime HoraAgora = DateTime.Now;

Console.WriteLine("Digite sua data de nascimento Ex: 04/11/1954 07:43:14");

DateTime Nascimento = Convert.ToDateTime(Console.ReadLine());
TimeSpan diferenca = HoraAgora - Nascimento;

int ano = diferenca.Days / 365;
int mes = diferenca.Days / 12;
int dias = diferenca.Days % 365;

Console.WriteLine($"A diferença de tempo é de:{ano} ano(s), {mes} meses, {dias} dias, {diferenca.Hours} horas, {diferenca.Minutes} minutos e {diferenca.Seconds} segundos.");

