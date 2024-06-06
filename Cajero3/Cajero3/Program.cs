using System;

namespace Cajero3
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //double monto;
            Console.WriteLine("Hello World!");
        }

    }

    public class cuentaBancaria
    {
        public string titular;
        private double saldo;
        double monto;

        public cuentaBancaria(string titular, double saldo)
        {
            this.titular = titular;
            this.saldo=saldo;
        }
        public void depositarEfectivo(double saldo)
        {
            saldo += monto;
        }
        public double consultarSaldo ()
        { 
            return saldo;
        }
    }


    
}
