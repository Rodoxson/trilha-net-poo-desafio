using DesafioPOO.Models;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Testando a classe Nokia
        Console.WriteLine("Testando o Nokia:");
        Nokia nokia = new Nokia("12345", "Nokia Model X", "1234567890", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");
        Console.WriteLine();

        // Testando a classe Iphone
        Console.WriteLine("Testando o Iphone:");
        Iphone iphone = new Iphone("67890", "Iphone 12", "0987654321", 128);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
        Console.WriteLine();
    }
}
