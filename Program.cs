using System;

namespace DesafioPOO.Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Smartphone Nokia:");
            // Criando um objeto Nokia
            Nokia nokia = new Nokia("123456789", "Nokia 3310", "IMEI123", 128);

            // Executando as funções do Nokia
            nokia.Ligar();
            nokia.InstalarAplicativo("WhatsApp");

            // Criando um objeto iPhone
            Console.WriteLine("Smartphone iPhone:");
            Iphone iphone = new Iphone("987654321", "iPhone 13", "IMEI456", 512);

            // Executando as funções do iPhone
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("Telegram");
        }
    }
}