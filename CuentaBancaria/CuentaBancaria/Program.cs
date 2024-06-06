using System;
using System.Collections.Generic;
using System.Linq;

namespace CuentaBancaria
{
    public class cuentaBancaria
    {
        string noCuenta;
        int pin;
        string nombre;
        string apellido;
        double saldo;

        public cuentaBancaria(string noCuenta, int pin, string nombre, string apellido, double saldo)
        {
            this.noCuenta = noCuenta;
            this.pin = pin;
            this.nombre = nombre;
            this.apellido = apellido;
            this.saldo = saldo;
        }

        public string getNoCuenta()
        {
            return noCuenta;
        }
        public int getPin() 
        {
            return pin;
        }

        public string getNombre()
        {
            return nombre;
        }

        public string getApellido()
        {
            return apellido;
        }
        public double getSaldo()
        {
            return saldo;
        }

        public void setNoCuenta(string newNoCuenta)
        {
            noCuenta=newNoCuenta;
        }
        private void setPin(int newPin)
        {
            int pin=newPin;
        }
        public void setNombre(string newNombre)
        {
            string nombre=newNombre;
        }
        public void setApellido(string newApellido)
        {
            string apellido=newApellido;
        }
        public void setSaldo(double newSaldo)
        {
            double saldo=newSaldo;
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {

            //Imprimir opciones para el usurio - Instrucciones
            void mostrarOpciones()
            {
                Console.WriteLine("Por favor seleccione una de las opciones a realizar...");

                Console.WriteLine("1.   Consulta de balance");
                Console.WriteLine("2.   Deposito a su cuenta");
                Console.WriteLine("3.   Retiro de efectivo ");
                Console.WriteLine("0.   Salir de su cuenta");
            }
            
            //Consulta de Saldo
            void consultarSaldo (cuentaBancaria usuarioActual) 
            {
                Console.WriteLine("Su balance actual es de: " + usuarioActual.getSaldo());
            }

            //Deposito de edectivo a su Cuenta Bancaria
            void depositarEfectivo (cuentaBancaria usuarioActual)
            {
                double a;

                Console.WriteLine("Por favor, digite el monto que desea depositar a su cuenta: ");
                double depositaEfectivo=double.Parse(Console.ReadLine());
                a =usuarioActual.getSaldo() + depositaEfectivo;
                //usuarioActual.setSaldo(usuarioActual.getSaldo() + depositaEfectivo);
                Console.WriteLine("Gracias por depositar a su cuenta " + depositaEfectivo + ", su nuevo balance es de: " + a);
            }

            //Retiro de edectivo desde su Cuenta Bancaria
            void retirarEfectivo (cuentaBancaria usuarioActual)
            {
                Console.WriteLine("Por favor, digite la cantidad a retirar en efectivo de su cuenta: ");
                double retiroEfectivo=double.Parse(Console.ReadLine());
                double b;

                //Verificar si el monto ingresado menor al monto en Saldo.
                if (usuarioActual.getSaldo() < retiroEfectivo)
                {
                    Console.WriteLine("Usted no tiene saldo suficiente para este monto, por favor intente con un monto menor o consulte su saldo. :( ");
                }
                else
                {
                    b = usuarioActual.getSaldo();
                    b=usuarioActual.getSaldo() - retiroEfectivo;
                    Console.WriteLine("Ahí tienes tu efectivo " + retiroEfectivo +" su nuevo balance es de: " + b);
                    Console.WriteLine("Gracias por utilizar nuestra red de cajeros ATM. :-p") ;
                }
            }

            //Lista de clientes para buscar en nuestra base de datos.
            List<cuentaBancaria> cuentasClientes=new List<cuentaBancaria>();
            cuentasClientes.Add(new cuentaBancaria("20240",1234,"Juan","Soto",5000));
            cuentasClientes.Add(new cuentaBancaria("20241",1235,"Hector","Acosta",15000));
            cuentasClientes.Add(new cuentaBancaria("20242",1236,"George","Castro",23000));

            // Mensaje de bienvenida para el usuario.
            Console.WriteLine("Bienvenido/@ a nuestra red de Cajeros automaticos en todo el país. ");
            Console.WriteLine("Por favor, ingrese el numero de cuenta a consultar: ");
            string tarjetaDebito = "";
            cuentaBancaria usuarioActual;

            while (true) 
            {
                try
                {
                    tarjetaDebito = Console.ReadLine();

                    usuarioActual =cuentasClientes.FirstOrDefault(a => a.getNoCuenta() == tarjetaDebito);
                    if (usuarioActual != null) { break; }
                    else {Console.WriteLine("Numero de cuenta incorrecto, por favor verifique el numero o trate mas tarde :-("); }

                }
                catch {Console.WriteLine("Numero de cuenta incorrecto, por favor verifique el numero o trate mas tarde :-("); }
            }
            Console.WriteLine("Por favor, introduzca los 4 dígitos de su PIN: ");
            int usuarioPin = 0;

            while (true)
            {
                try
                {
                    usuarioPin = int.Parse(Console.ReadLine());
                    if (usuarioActual.getPin() == usuarioPin) { break; }
                    else { Console.WriteLine("PIN incorrecto, intentelo de nuevo por favor. :-c"); }
                } catch { Console.WriteLine("PIN incorrecto, intentelo de nuevo por favor. :-c"); }
            }
                Console.WriteLine("Bienvenido a nuesta red de Cajeros automaticos " + usuarioActual.getNombre() + " " + usuarioActual.getApellido());

                int opcion = 0;

                do
                {
                    mostrarOpciones();
                    try
                    {
                        opcion = int.Parse(Console.ReadLine());
                    }
                    catch { }
                if (opcion == 1) { consultarSaldo(usuarioActual); }
                else if (opcion == 2) { depositarEfectivo(usuarioActual); }
                else if (opcion == 3) { retirarEfectivo(usuarioActual); }
                else if (opcion == 0) { break; }
                //else if (opcion == 4) { break; }
                //else { opcion = 0; }
                }
                while (opcion !=4 );
                Console.WriteLine("Gracias por utilizar nuestros servicios, face excelente resto del día! :)");
            }

        }
    }


