using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_telefonica
{
    public class Contato
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Telefone { get; set; }


        public Contato(string nome, string email, int telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }

    public class gerenciadorContato {

        public List<Contato> agenda = new List<Contato>
         {
         new Contato("Afonso","caribe@gmail.com",123456789),
         new Contato("Larissa", "carbono@gmail.com", 987654321),
         new Contato("Pedro","louro@gmail.com",549111),
         };

        public void AdicionarContato(string nome, string email, int telefone)
        {
            var NovoContato = new Contato(nome, email, telefone);
            agenda.Add(NovoContato);
            Console.WriteLine("Seu Contato foi adicionado!");
            VerContato();
        }

        public void VerContato()
        {
            foreach (Contato contato in agenda)
            {
                Console.WriteLine($"Nome: {contato.Nome}, Email: {contato.Email}, Telefone: {contato.Telefone}");
            }
        }

        public void RemoverContato(string nome)
        {
           for (int i = 0; i <= agenda.Count; i++)
            {
                if (agenda[i].Nome == nome) {
                    agenda.RemoveAt(i);
                    Console.WriteLine($"{nome} foi removido(a) da agenda!\n");
                    VerContato();
                    return;
                }
            }
            Console.WriteLine("Não foi possivel achar o nome digitado.");
        }

        public void EncontrarTelefone(string pista)
        {
            for( int i = 0; i < agenda.Count; i++)
            {
                if (agenda[i].Nome == pista || agenda[i].Email == pista)
                {
                    Console.Write($"\nO telefone de {agenda[i].Nome} é {agenda[i].Telefone}\n");
                    return;
                }
            }
        }
    }
}
