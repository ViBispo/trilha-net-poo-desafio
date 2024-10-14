using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"147852", modelo:"modelo1", imei:"11111", memoria:64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero:"369852", modelo:"modelo2", imei:"22222", memoria:128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
// TODO: Realizar os testes com as classes Nokia e Iphone