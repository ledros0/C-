using Gestão_de_animais;

Zoologico zoologico =  new Zoologico();
Mamifero vaca = new Mamifero("Mamifero", "vaca", "muuuuuu"  ,"preto e branco", "grama");
Ave tucano = new Ave("Ave", "tucano", "Cacau", "Asa muscular", "Todas as cores existentes");
Reptil crocodilo = new Reptil("Reptil", "crocodilo", "Rrrrrr", "2 metros", "Terrestre/Aquatico");
VisitanteRapido jailson = new VisitanteRapido();

zoologico.AdicionarAnimal(vaca);
zoologico.VerAnimal(0);
zoologico.QuantidadeAnimais();

zoologico.AdicionarAnimal(tucano);
zoologico.VerAnimal(1);
tucano.EmitirSom();

zoologico.AdicionarAnimal(crocodilo);
zoologico.VerAnimal(2);

zoologico.RemoverAnimal(0);
zoologico.QuantidadeAnimais();

zoologico.ReceberVisita(jailson);