using Gestão_de_animais;

Zoologico zoologico =  new Zoologico();
Mamifero vaca = new Mamifero("Mamifero", "vaca", "preto e branco", "grama");
Ave tucano = new Ave("Ave", "tucano", "Asa muscular", "Todas as cores existentes");
Reptil crocodilo = new Reptil("Reptil", "crocodilo", "2 metros", "Terrestre/Aquatico");

zoologico.AdicionarAnimal(vaca);
zoologico.VerAnimal(0);
zoologico.QuantidadeAnimais();

zoologico.AdicionarAnimal(tucano);
zoologico.VerAnimal(1);

zoologico.AdicionarAnimal(crocodilo);
zoologico.VerAnimal(2);

zoologico.RemoverAnimal(0);
zoologico.QuantidadeAnimais();