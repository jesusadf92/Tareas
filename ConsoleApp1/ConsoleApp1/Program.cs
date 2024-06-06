using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto;
            Console.WriteLine("Inserta una cadena de texto: ");
            Console.WriteLine();
            texto=Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Usted ha ingresado el texto: ' " + texto + " '.");
            Console.ReadKey();
        }
    }
}
