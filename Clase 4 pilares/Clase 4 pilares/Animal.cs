using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_4_pilares
{

        public abstract class Animal //Esta es la Clase
        {
            public int Edad { get; set; } // Estos son atributos de los objetos
            public string Raza { get; set; }

            public void Comer()
            {
                Console.WriteLine("El animal esta comiendo.");
            }
        }

        public  class Perro:Animal 
        {
            public void Ladrar()
            {
                Console.WriteLine("El perro esta Ladrando.");
            }
        }


        public class  Gato:Animal //A esto se le llama Herencia, la capacidad de poder usar clases y atributos de otra clase.
        {
            
        }

        public class Pez:Animal
        {
            public void Nadar() //A esto se le llama Polimorfismo, porque permite utilizar el mismo nombre pero con diferentes parametros.
            {
                Console.WriteLine("El pez esta nadando en sus aguas.");
            }
            
        }

        public class Ave:Animal
        {
        public void Volar()
        {
            Console.WriteLine("El ave vuela por los aires libremente.");
        }
        }

        public class Rectangulo (int _base, int _altura)
        { 
            public int Base {get;set;}
            public int Altura { get; set; }
            //public class Rectangulo(int _base, int _altura)
            //{
            //    Base=_base;
            //    Altura=_altura;

            //}
            public int ObtenerArea()
            {
                return Base * Altura;
            }
      

            public class Cuadrado : Rectangulo
            {
                public Cuadrado(int Dimension)
                {
                    Base = Dimension;
                    Altura = Dimension;
                }
            }
        }
        }

