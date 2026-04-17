using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    class Vectores
    {
        /*1.
         Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
         del vector.
        */

        private int[] Vector;
        private int menor;
        public void cargar()
        {
            Console.WriteLine("ingrese la cantidad de elementos: ");
            string linea;
            linea = Console.ReadLine();
            Vector = new int[int.Parse(linea)];

            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                linea = Console.ReadLine();
                Vector[i] = int.Parse(linea);
                if(i == 0) 
                {
                    menor = Vector[i];
                    Console.WriteLine("este es el numero mas chico");
                }
                if(menor > Vector[i])
                {
                    menor = Vector[i];
                    Console.WriteLine("Ahora este es el numero mas chico");
                }
                if (Vector[i] == menor && i != 0)
                {
                    Console.WriteLine("se repite el numero menor");
                }
            }
        }
        static void Main(string[] args)
        {
        Vectores v1 = new Vectores();
        v1.cargar();
        Console.ReadKey();
        }
    }
}