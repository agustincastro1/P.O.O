using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*  3. Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
        (el orden lo pueden elegir ustedes). */
    class Vectores3
    {
        private int[] Vector;
        private int[] VectorSinOrdenar;

        public void cargar()
        {
            Console.WriteLine("ingrese la cantidad de elementos: ");
            string linea;
            linea = Console.ReadLine();
            Vector = new int[int.Parse(linea)];
            VectorSinOrdenar = new int[int.Parse(linea)];
            for (int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                linea = Console.ReadLine();
                Vector[i] = int.Parse(linea);
                VectorSinOrdenar[i] = int.Parse(linea);
            }
        }
        public void calcular()
        {
            int aux;
            for (int i = 0; i < Vector.Length; i++)
            {
                for (int t = 0; t < Vector.Length - i - 1; t++)
                {
                    if (Vector[t] > Vector[t + 1])
                    {
                        aux = Vector[t];
                        Vector[t] = Vector[t + 1];
                        Vector[t + 1] = aux;
                    }
                }
            }
        }

        public void mostrar()
        {
            Console.WriteLine("vector sin ordenar: ");
            for (int i = 0; i<Vector.Length;i++)
            {
                Console.WriteLine(VectorSinOrdenar[i]);
            }
            Console.WriteLine("vector ordenado: ");
            for(int i = 0; i < Vector.Length; i++)
            {
                Console.WriteLine(Vector[i]);
            }
        }
        static void Main(string[] args)
        {
            Vectores3 v3 = new Vectores3();
            v3.cargar();
            v3.calcular();
            v3.mostrar();
            Console.ReadKey();
        }
    }
}
