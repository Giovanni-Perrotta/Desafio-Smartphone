using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia cell1 = new Nokia();

Iphone cell2 = new Iphone();


//Teste Nokia
Console.WriteLine("Nokia: ");
cell1.Ligar();
cell1.ReceberLigacao();
cell1.InstalarAplicativo("WhatsApp");

//Teste Iphone
Console.WriteLine("Iphone: ");
cell2.Ligar();
cell2.ReceberLigacao();
cell2.InstalarAplicativo("Instagram");