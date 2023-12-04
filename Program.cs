using DesafioPOO.Models;

Console.WriteLine("Testes Iphone:");
Smartphone iphone = new Iphone("XXXXXXXXXXX", "Model S", "1223334444", 128);
iphone.Ligar();
iphone.InstalarAplicativo("VSCODE MOBILE");
//
Console.WriteLine("Testes Nokia:");
Smartphone nokia = new Nokia("XXXXXXXXXXX", "Nokia Tijolao", "4444333221", 64);
nokia.Ligar();
nokia.InstalarAplicativo("NEW CODE");
