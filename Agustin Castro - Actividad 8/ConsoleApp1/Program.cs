using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class Vectores2
    {
        /*
            2. Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
               algoritmo de ordenamiento alfabético.
        */
        private string[] vector;
        
        public void cargar()
        {
            string linea;
            vector = new string[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("ingrese el nombre de un país: ");
                linea = Console.ReadLine();
                vector[i] = linea;
            }
        }

        public void ordenar()
        {
            for (int i = 0;i < vector.Length; i++)
            {
                for(int j = 0;j < vector.Length - i; j++)
                {
                    if (j!= 4) {
                        if (vector[j].CompareTo(vector[j + 1]) > 0)
                        {
                            string aux;
                            aux = vector[j];
                            vector[j] = vector[j + 1];
                            vector[j + 1] = aux;
                        }
                    }
                }
            }
        }

        public void imprimir()
        {
            Console.WriteLine("paises ordenados alfabericamente: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
         static void Main(string[] args)
        {
            Vectores2 v2 = new Vectores2();
            v2.cargar();
            v2.ordenar();
            v2.imprimir();
            Console.ReadKey();
        }
    }
}

