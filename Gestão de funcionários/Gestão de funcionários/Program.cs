using Gestão_de_funcionários;

FuncionarioRegular funcionarioRegular = new FuncionarioRegular("João", 22, 7500 );
funcionarioRegular.MostrarFuncionario();

Console.WriteLine("\n");

Gerente gerente = new Gerente("Gustavo", 44, 12000);
gerente.MostrarFuncionario();
gerente.AumentarSalario();

Console.WriteLine("\n");

Diretor diretor = new Diretor("Osvaldo", 61, 20000);
diretor.MostrarFuncionario();
diretor.AumentarSalario();