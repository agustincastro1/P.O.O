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
            /*3. Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            a) La cantidad de valores ingresados negativos.
            b) La cantidad de valores ingresados positivos.
            c) La cantidad de múltiplos de 15.
            d) El valor acumulado de los números ingresados que son pares.*/
            
            int num, CantNegativos = 0, CantPositivos = 0, MultDe15 = 0, Pares = 0;
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                num = int.Parse(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Pares++;
                }
                if(num < 0)
                {
                    CantNegativos++;
                }
                if(num > -1)
                {
                    CantPositivos++;
                }
                if (num % 15 == 0)
                {
                    MultDe15++;
                }
            }
            Console.WriteLine("Cantidad de valores positivos: " + CantPositivos);
            Console.WriteLine("Cantidad de valores negativos: " + CantNegativos);
            Console.WriteLine("cantidad de valores multiplos de 15: " + MultDe15);
            Console.WriteLine("cantidad de valores pares: " + Pares);
            Console.ReadKey();
        }
    }
}
