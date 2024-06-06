using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Animal
    {
        public string NombreAnimal { get; set; }
        public virtual void HacerSonido() //Firma de un metodo 
        {
            //Implementacion es todo lo que hace
            Console.WriteLine("El animal esta haciendo un sonido.");
        }


    }
}
