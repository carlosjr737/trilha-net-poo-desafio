using DesafioPOO.Models;

System.Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "9 92007826", modelo: "N96", imei: "DDD", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("tinder");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "9 7304200", modelo: "13", imei: "DDD", memoria: 64);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Wpp");