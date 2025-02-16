using System.Collections.Generic;

List<string> ListaAnimal = new List<string>();

Console.WriteLine("Coloque o nome dos animais que você queira.\nCaso queira sair do programa digite 'sair'. ");

string adicionar = null;
Boolean programa = true;
while (programa)
{
    adicionar = Console.ReadLine();

    if (ListaAnimal.Contains(adicionar))
    {
        Console.WriteLine("Esse animal já está listado, tente outro");
    }
    else
    {
        ListaAnimal.Add(adicionar); 
    }

    while (adicionar == "sair")
    {
        Environment.Exit(0);
    }
    Console.WriteLine($"\nTem esses animais listados até agora:");

    foreach (string animais in ListaAnimal)
    {
        Console.Write($"{animais} - ");

        if(adicionar == "sair")
        {
            Environment.Exit(0);
        }
    }
}