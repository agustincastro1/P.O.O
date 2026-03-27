using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un programa que acumule (sume) valores ingresados por teclado hasta
            ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
            valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero. */
            int valor, suma = 0;
            string linea;
            do
            {
                Console.WriteLine("ingrese valores cualquiera, para finalizar ingrese el 9999: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;

                if(valor == 9999)
                {
                    suma = suma - valor;
                }
            }while (valor != 9999);
            Console.WriteLine("el valor acumulado es: " + suma);
            if (suma == 0)
            {
                Console.WriteLine("el valor acumulado es 0");
            }
            if (suma > 0)
            {
                Console.WriteLine("el valor acumulado es mayor a 0");
            }
            if (suma < 0)
            {
                Console.WriteLine("el valor acumulado es menor a 0");
            }
            Console.ReadKey();
        }
    }
}
