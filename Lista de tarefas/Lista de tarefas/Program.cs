using System.Collections.Generic;

void remover(List<string> lista, int RemoverColocação)
{
    lista.RemoveAt(RemoverColocação);
    return;
}

List<string> ListaDeTarefas = new List<string>();

Console.WriteLine("Crie sua própria lista de tarefas!");
Console.WriteLine("Para adicionar na lista clique 1 e para remover da lista clique 2.\nPara sair do programa clique 'sair'.\n");

string adicionar = null;
string escolha = null;
string remove = null;
while (true)
{
    escolha = Console.ReadLine();
    if (escolha == "2")
    {
        Console.WriteLine("Agora digite a colocação da tarefa que você quer tirar (0 é a primeira colocação).\n");
        remove = Console.ReadLine();
        int removeConvertido = Convert.ToInt32(remove);

        remover(ListaDeTarefas, removeConvertido);
    }

    else if (escolha == "1")
    {
        adicionar = Console.ReadLine();
       if (adicionar == null || ListaDeTarefas.Contains(adicionar))
    {
            Console.WriteLine("Inválido, não coloque tarefas repetidas e nem deixe em branco.\n");
        }
        ListaDeTarefas.Add(adicionar);
    }

    else if (escolha == "sair")
    {
        Environment.Exit(0);
    }

    foreach (string tarefa in ListaDeTarefas)
    {
            Console.Write($"\nTarefas: {tarefa}\n");
    }
}