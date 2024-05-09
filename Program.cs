using DesafioPOO.Models;

// TODO: FINALIZADO - Realizar os testes com as classes Nokia e Iphone

Iphone iphone1 = new Iphone("123456789", "Iphone 15", "abc12345", 128);
Nokia nokia1 = new Nokia("963852741", "Nokia 360", "xyz78945", 64);

Console.WriteLine("\n");

Console.WriteLine("Testando o " + iphone1.GetType().Name);

iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Testando o " + nokia1.GetType().Name);

nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Telegram");

Console.WriteLine("\n");
