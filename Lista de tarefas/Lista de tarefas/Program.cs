using System.Collections.Generic;
using System.Text;

void remover(List<string> lista, int RemoverColocação)
{
    if (RemoverColocação < 0)
    {
        RemoverColocação = 0;
    }

    lista.RemoveAt(RemoverColocação);
    return;
}

List<string> ListaDeTarefas = new List<string>();

Console.WriteLine("Crie sua própria lista de tarefas!");
Console.WriteLine("Para adicionar na lista clique 1, para remover da lista clique 2 e para salvar o arquivo clique 3.\n\nClique 4 para abir sua lista salva.\n\nPara sair do programa clique 'sair'.\n");

string adicionar = null;
string escolha = null;
string remove = null;
Boolean salvar = false;
int QuantidadeDeTarefas = 0;
string TextoCompleto = null;

StringBuilder texto = new StringBuilder();
while (true)
{

    escolha = Console.ReadLine();
    if (escolha == "2")
    {
        Console.WriteLine("Agora digite a colocação da tarefa que você quer tirar (0 é a primeira colocação).\n");
        remove = Console.ReadLine();
        int removeConvertido = Convert.ToInt32(remove);

        remover(ListaDeTarefas, removeConvertido);
        QuantidadeDeTarefas--;
    }

    else if (escolha == "1")
    {
        adicionar = Console.ReadLine();
        if (adicionar == null || ListaDeTarefas.Contains(adicionar))
        {
            Console.WriteLine("Inválido, não coloque tarefas repetidas e nem deixe em branco.\n");
        }
        ListaDeTarefas.Add(adicionar);
        QuantidadeDeTarefas++;
    }

    else if (escolha  == "3")
    {
        salvar = true;
    }

    else if (escolha == "4")
    {
        string ArquivoSalvo = File.ReadAllText("Tarefas.txt");
        Console.WriteLine($"{ArquivoSalvo}");
    }

    else if (escolha == "sair")
    {
        Environment.Exit(0);
    }

    foreach (string tarefa in ListaDeTarefas)
    {
        Console.Write($"\nTarefas: {tarefa}\n");

        texto.Append(tarefa);
        TextoCompleto = texto.ToString(); 
        if (salvar = true)
        {
            File.WriteAllText("Tarefas.txt", TextoCompleto);           
        }
    } 
}
