using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
            //(No se ingresan valores por teclado)

            int x = 11;
            int n = 1;
            Console.WriteLine("Serie de 11:");
            while (n <= 25)
            {
                Console.WriteLine(x);
                x = x + 11;
                n++;
            }
            Console.ReadKey();
        }
    }
}
