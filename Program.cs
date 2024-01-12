using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
internal class Program
{
    static void Main(string[] args)
    {
        Smartphone nokia = new Nokia("123", "modelo", "imei", 5);
        nokia.InstalarAplicativo("appNokia");

        Smartphone iphone = new Iphone("123", "modelo", "imei", 5);
        iphone.InstalarAplicativo("appIphone");

        Console.ReadKey();

    }
}
