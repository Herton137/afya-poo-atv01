var p = new Personagem("Arthas", "Guerreiro");

Console.WriteLine(p);

Console.WriteLine("\nRecebendo dano 50...");
p.ReceberDano(50);

Console.WriteLine(p);

Console.WriteLine("\nSubindo nível...");
p.SubirNivel();

Console.WriteLine(p);

Console.WriteLine("\nRecebendo dano mortal...");
p.ReceberDano(999);

Console.WriteLine(p);

Console.WriteLine("\nTentando curar morto (não deve funcionar)...");
p.Curar(50);

Console.WriteLine(p);

Console.WriteLine("\nTentando subir nível morto (não deve funcionar)...");
p.SubirNivel();

Console.WriteLine(p);
