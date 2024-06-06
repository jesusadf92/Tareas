using System;

namespace Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro perro = new Perro();
            Gato gato = new Gato();

            gato.HacerSonido();
            perro.HacerSonido();
        }
    }
}
