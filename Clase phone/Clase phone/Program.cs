using System;
using System.Numerics;

namespace Clase_phone
{
    internal class Program
    {
        static void Main(string[] args)
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
            Samsung.Brand = "Samsung";
            Samsung.Model = "S25 Ultra";

            Console.Write("El telefono " + Samsung.Brand + " " + Samsung.Model);
            Samsung.Encender();
            Samsung.Cargar();

            Console.Write("El telefono " + Iphone01.Brand + " " + Iphone01.Model);
            Iphone01.Apagado();
            Iphone01.Cargar();

            Console.ReadKey();


        }
    }

    public class phone
    {
        public string ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }

        public void Encender()
        {
            Console.Write(" esta encendido");
        }

        public void Apagado()
        {
            Console.Write(" y apagando");
        }

        public void Cargar()
        {
            Console.WriteLine(" y cargando");
        }
    }


}
