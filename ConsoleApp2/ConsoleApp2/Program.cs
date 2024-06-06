using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static string Main(string[] args)
        {
            phone Iphone01 = new phone();
            Iphone01.ID = "iphone5xxx1";
            Iphone01.Brand = "Apple";
            Iphone01.Model = "Iphone 5s Plus";

            phone Google = new phone();
            Google.ID = "Google0001";
            Google.Brand = "Google";
            Google.Model = "Pixel 6";

            phone Samsung = new phone();
            Samsung.ID = "samgxxx01-3";
            Samsung.Brand= "Samsung";
            Samsung.Model = "S25 Ultra";

            Console.Write("El " + Samsung.Brand + " " + Samsung.Model);
            Samsung.Encender();
            Samsung.Cargar();


        }
    }

    public class phone
    {
        public string ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Encender()
        {
            Console.WriteLine("El telefono esta encendiendo");
        }

        public void Apagado()
        {
            Console.WriteLine("El telfono se esta apagando");
        }

        public void Cargar()
        {
            Console.WriteLine("El telefono esta cargando");
        }
    }
}
