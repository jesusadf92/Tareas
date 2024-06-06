using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Perro : Animal
    {
        public override void HacerSonido()
        {
            base.HacerSonido();
            Console.WriteLine("El Perro hace: jau jau jau jauuuuuuuuuuuuu");
        }

    }
}
