using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("99991111", "Modelo A", "11111", 32);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("88882222", "Modelo B", "22222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
