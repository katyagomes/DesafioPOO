using DesafioPOO.Models;

// Teste com Nokia
Console.WriteLine("--- Smartphone Nokia ---");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1100", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n"); 

// Teste com iPhone
Console.WriteLine("--- Smartphone iPhone ---");
Smartphone iphone = new Iphone(numero: "4987", modelo: "iPhone 15 Pro", imei: "222222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");
