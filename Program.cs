using DesafioPOO.Models;

Iphone iPhone = new("11999999999", "iPhone 10", "998376265698348", 256);
iPhone.Ligar();
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("WhatsApp");

Nokia nokia = new("11999999998", "Nokia X5", "102343273090978", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");