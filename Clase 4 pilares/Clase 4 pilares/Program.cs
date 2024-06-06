using System;
using static Clase_4_pilares.Rectangulo;

namespace Clase_4_pilares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Perro Pitbull=new Perro(); //A esto se le llama crear una nueva instancia.
            Gato gatoAngora=new Gato();
            Pez Tilapia = new Pez();
            Ave Aguila = new Ave();

            Pitbull.Comer(); //A esto se le llama adignar un nuevo metodo
            Pitbull.Ladrar();
            gatoAngora.Comer();
            Tilapia.Comer();
            Aguila.Comer();



            int _base = 2;
            int _altura = 4;


            Rectangulo r = new Rectangulo(_base, _altura);
            int area = r.ObtenerArea();
            Console.WriteLine(area);


            int _dimension = 5;
            Cuadrado c = new Cuadrado(_dimension);
            int areaCuadreado = c.ObtenerArea();


        }
    }
}
