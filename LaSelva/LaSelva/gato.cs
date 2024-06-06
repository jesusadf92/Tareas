using System;
using System.Collections.Generic;
using System.Text;

namespace Animal
{
    public class Gato : Animal
    {
        public override void HacerSonido()
        {
            base.HacerSonido();
            Console.WriteLine("El gato hace: Miau miau miau");
        }
    }
}
