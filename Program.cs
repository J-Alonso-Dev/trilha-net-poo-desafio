using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        // Criando um Nokia
        Console.WriteLine("Testando Nokia:");
        Smartphone nokia = new Nokia("123456789", "Nokia G21", "111111111", 128);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

        // Criando um iPhone
        Console.WriteLine("\nTestando iPhone:");
        Smartphone iphone = new Iphone("987654321", "iPhone 13", "222222222", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");
    }
}