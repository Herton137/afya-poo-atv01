var conta = new Conta(1, "Maria");

Console.WriteLine(conta);

Console.WriteLine("\nDepositando 300...");
conta.Depositar(300);

Console.WriteLine(conta);

Console.WriteLine("\nSacando 600 (usa limite)...");
conta.Sacar(600);

Console.WriteLine(conta);
Console.WriteLine($"Status: {conta.StatusConta}");

Console.WriteLine("\nTentando sacar além do limite...");
Console.WriteLine(conta.Sacar(1000)); // false

Console.WriteLine(conta);
