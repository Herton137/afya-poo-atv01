var c = new Cofre("João", "123");

Console.WriteLine(c.Abrir("111"));
Console.WriteLine(c.Abrir("222"));
Console.WriteLine(c.Abrir("333")); // deve bloquear

Console.WriteLine(c.Abrir("123")); // não deve abrir (bloqueado)

Console.WriteLine("\nCriando novo cofre...");
c = new Cofre("João", "123");

Console.WriteLine(c.Abrir("123")); // abre

Console.WriteLine("Alterando senha...");
Console.WriteLine(c.AlterarSenha("123", "456"));

c.Fechar();

Console.WriteLine("Tentando abrir com senha nova:");
Console.WriteLine(c.Abrir("456"));
