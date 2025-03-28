using Agenda_telefonica;
using System.Collections.Generic;

var gerenciador = new gerenciadorContato(); 

Console.WriteLine("Sua lista de contatos: ");
gerenciador.VerContato();

Console.WriteLine("\nAdicione alguem agora! (Nome,Email,Telefone)\n");
string addN = Console.ReadLine();
string addE = Console.ReadLine();
int addT = Convert.ToInt32(Console.ReadLine());

gerenciador.AdicionarContato(addN, addE, addT);

Console.WriteLine("\nAgora digite o nome do contato que deseja remover\n");
string delC = Console.ReadLine();

gerenciador.RemoverContato(delC);

Console.WriteLine("Busque um contato pelo nome ou email, para devolver seu telefone");
string procC = Console.ReadLine();

gerenciador.EncontrarTelefone(procC);