using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
            //muestre la tabla de multiplicar del mismo(los primeros 13 términos)
            //Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 30.
            int num;
            Console.WriteLine("Ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            int x = num;
            for (int i = 0; i < 13; i++)
            {
                num = x * (i+1);
                Console.Write(num);
                Console.Write("-");
            }
            Console.ReadKey();
        }
    }
}
