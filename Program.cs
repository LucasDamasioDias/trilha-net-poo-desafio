using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone celular1 = new Iphone("319999999", "Iphone6", "5555555", 32);
Nokia celular2 = new Nokia("3188888", "3320", "2222222", 16);

Console.WriteLine($"Usando o {celular1.GetType().Name} {celular1.Numero}");
celular1.Ligar();
celular1.ReceberLigacao();
celular1.InstalarAplicativo("Facebook");

Console.WriteLine();

Console.WriteLine($"Usando o {celular2.GetType().Name} {celular2.Numero}");
celular2.Ligar();
celular2.ReceberLigacao();
celular2.InstalarAplicativo("Instagram");