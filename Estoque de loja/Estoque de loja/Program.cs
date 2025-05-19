using Estoque_de_loja;

Alimento CocaCola = new Alimento("Coca-cola", "29/09/2029", 2.50, "Latinha de coca");
Roupa Blusa = new Roupa("Blusa", "G", 56.50, "Blusa azul quentinha");
Eletronico Celular = new Eletronico("Sansung", "S22 Ultra", 3500, "Celular bombastico");

Loja1 Loja_do_ze = new Loja1("Loja do Zezinho");
Loja2 Loja_da_tiana = new Loja2("Loja da Tia aninha");

Loja_do_ze.EstocarProduto(CocaCola);
Loja_do_ze.VenderProduto(CocaCola);

Loja_da_tiana.EstocarProduto(Celular);
Loja_da_tiana.VenderProduto(Celular);
