using DesafioPOO.Models;

Nokia nokia = new Nokia("11998444551", "Nokia Tijolão", "GRASK", 128);
Iphone iphone = new Iphone("11998555441", "iPhone de Botão", "KORK", 256);

Console.WriteLine($"MEU NOKIA É: {nokia}");
nokia.Ligar();
nokia.InstalarAplicativo("Snake");

Console.WriteLine();

Console.WriteLine($"MEU IPHONE É: {iphone}");
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");