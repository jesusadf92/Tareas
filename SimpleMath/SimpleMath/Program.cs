using System;

namespace SimpleMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado;
            
            Console.WriteLine("Inserte dos numero a calcular: ");
            Console.WriteLine("Inserte un numero diferente de 0");
            num1=Double.Parse(Console.ReadLine());
            
            while (num1 == 0)
            {
                Console.WriteLine("El numero dos no puede ser 0");
                num1 = Double.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("Inserte el otro numero diferente de 0, inserte otro numero");
            num2 = Double.Parse(Console.ReadLine());

            while (num2 == 0)
            {
                Console.WriteLine("El numero dos no puede ser 0, inserte otro numero");
                num2 = Double.Parse(Console.ReadLine());
            }

            Console.WriteLine(num1 + " + " + num2 + " = " + (resultado = num1 + num2));
            Console.WriteLine(num1 + " - " + num2 + " = " + (resultado = num1 - num2));
            Console.WriteLine(num1 + " x " + num2 + " = " + (resultado = num1 * num2));
            Console.WriteLine(num1 + " / " + num2 + " = " + (resultado = num1 / num2));
            Console.WriteLine();                     
          
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
            


        }
    }
}
