using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
                cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
                finalizar al ingresar un valor negativo en el número de cuenta.
                Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
                informe:
                a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
                que:
                Estado de la cuenta:
                ○ “Acreedor” si el saldo es >0.
                ○ “Deudor” si el saldo es <0.
                ○ “Nulo” si el saldo es =0.
                b) La suma total de los saldos acreedores.
             */

            int numeroCuenta, saldoActual=0, saldoAcreedores = 0;
            string estadoCuenta = "", info = "";
            string linea;
            do
            {
                Console.WriteLine("Ingrese el numero de cuenta (para finalizar ingrese un numero negativo): ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);

                if (numeroCuenta > 0)
                {
                    Console.WriteLine("Ingrese el saldo de su cuenta: ");
                    linea = Console.ReadLine();
                    saldoActual = int.Parse(linea);


                    if (saldoActual > 0)
                    {
                        estadoCuenta = "Acreedor. ";
                    }
                    if (saldoActual == 0)
                    {
                        estadoCuenta = " Nulo.";
                    }
                    if (saldoActual < 0)
                    {
                        estadoCuenta = " Deudor. ";
                    }
                    info = info + "Numero de cuenta: " + numeroCuenta + " Estado de la cuenta: " + estadoCuenta;
                    saldoAcreedores = saldoAcreedores + saldoActual;
                }
            } while (numeroCuenta > 0);
            Console.WriteLine(info + " Saldo de acreedores: " + saldoAcreedores);
            Console.ReadKey();        
        }
    }
}
