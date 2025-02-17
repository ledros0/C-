using System.Collections.Generic;

Dictionary<string, int> Mercado = new Dictionary<string, int>();

Mercado.Add("Suco de laranja", 4);
Mercado.Add("Agua com gas", 7);
Mercado.Add("Coca-Cola", 14);

Console.WriteLine("Bem vindo ao caixa! O que você gostaria de fazer?\n\n1 - Ver os produtos\n2 - Adicionar itens\n3 - Pegar um item\nQualquer outro número irá encerrar o caixa.\n");

string escolha = null;
while (true)
{
    escolha = Console.ReadLine();
    Console.WriteLine();

    if (escolha == "1")
    {
        foreach (string produto in Mercado.Keys)
        {
            int Quantidade = Mercado[produto];
            Console.WriteLine($"{produto}\n{Quantidade} unidades(s)\n");
        }
    }
    else if (escolha == "2")
    {
        Console.WriteLine("Diga qual item você quer adicionar, e sua quantidade");
        String AdicionarProduto = Console.ReadLine();
        int AdicionarQuantidade = Convert.ToInt32(Console.ReadLine());

        if (Mercado.ContainsKey(AdicionarProduto))
        {
            Console.WriteLine("Este item já existe no mercado, Quantas quantidades gostaria de adicionar nele?");
            int somarItem = Convert.ToInt32(Console.ReadLine());
            Mercado.Add(AdicionarProduto, AdicionarQuantidade + somarItem);
        }
        Mercado.Add(AdicionarProduto, AdicionarQuantidade);
    }
    else if (escolha == "3")
    {
        Console.WriteLine("Qual item você gostaria de pegar? E sua quantidade?");
        string Produto = Console.ReadLine();
        int QuantidadeRetirada = Convert.ToInt32(Console.ReadLine());
        Mercado[Produto] -= QuantidadeRetirada;

        if (Mercado[Produto] < 0)
        {
            Mercado[Produto] = 0;
        }

    }
    else
    {
        Environment.Exit(0);
    }
}
