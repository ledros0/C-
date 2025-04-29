using Transações_bancárias;

ContaCorrente conta1 = new ContaCorrente("Gustavo", 992811110, 54232111, 1000000, 555.4);
conta1.Depositar(600);
conta1.Sacar(700);

ContaPoupanca conta2 = new ContaPoupanca("Vinicius", 31231231, 13213123, 311323, 50000);
conta1.Depositar(600);
conta1.Sacar(700);

ContaInvestimento conta3 = new ContaInvestimento("Algusto", 534534534, 53453453, 54534534, 39281);
conta1.Depositar(600);
conta1.Sacar(700);
