var l = new Lampada("Philips", "LED");

Console.WriteLine("Estado inicial:");
Console.WriteLine(l);

Console.WriteLine("\nLigando...");
l.Alternar();

Console.WriteLine("Ajustando brilho para 70...");
l.AjustarBrilho(70);

Console.WriteLine(l);

Console.WriteLine("\nDesligando...");
l.Alternar();

Console.WriteLine("Tentando mudar brilho desligada (não deve mudar)...");
l.AjustarBrilho(30);

Console.WriteLine(l);
