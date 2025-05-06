using Estoque_de_loja;

Alimento CocaCola = new Alimento("Coca-cola", "29/09/2029", 2.50, "Latinha de coca");
Roupa Blusa = new Roupa("Blusa", "G", 56.50, "Blusa azul quentinha");
Eletronico Celular = new Eletronico("Sansung", "S22 Ultra", 3.500, "Celular bombastico");
Loja1 Loja_do_ze = new Loja1();

Loja_do_ze.EstocarProduto(CocaCola, 6);
