using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    class Vectores4
    {
        /*4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
        habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
        ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
        nuevamente.*/

        private string[] vector;
        private int[] vector2;
        public void cargar()
        {
            string linea;
            vector = new string[5];
            vector2 = new int[5];
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine("ingrese el nombre de un país: ");
                linea = Console.ReadLine();
                vector[i] = linea;
                Console.WriteLine("ingrese el numero de habitantes de ese pais: ");
                linea = Console.ReadLine();
                vector2[i] = int.Parse(linea);
            }
        }
        public void ordenarAlfabeticamente()
        {
            for (int i = 0; i < vector.Length; i++)
            {
                for (int j = 0; j < vector.Length - i; j++)
                {
                    if (j != 4)
                    {
                        if (vector[j].CompareTo(vector[j + 1]) > 0)
                        {
                            int auxHab;
                            string aux;
                            aux = vector[j];
                            auxHab = vector2[j];
                            vector[j] = vector[j + 1];
                            vector2[j] = vector2[j + 1];
                            vector[j + 1] = aux;
                            vector2[j + 1] = auxHab;
                        }
                    }
                }
            }
        }
        public void mostrarAlf()
        {
            Console.WriteLine("array ordenado arfabeticamente: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i] + " cantidad de habitantes: " + vector2[i]);
            }
        }
        public void ordenarNumericamente()
        {
            int auxHab;
            string aux;
            for (int i = 0; i < vector2.Length; i++)
            {
                for (int t = 0; t < vector2.Length - i - 1; t++)
                {
                    if (t != 4)
                    {
                        if (vector2[t] < vector2[t + 1])
                        {
                            auxHab = vector2[t];
                            aux = vector[t];
                            vector2[t] = vector2[t + 1];
                            vector[t] = vector[t + 1];
                            vector2[t + 1] = auxHab;
                            vector[t + 1] = aux;
                        }
                    }
                }
            }
        }

        public void mostrarNum()
        {
            Console.WriteLine("vector ordenado numericamente: ");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }
        static void Main(string[] args)
        {
            Vectores4 v4 = new Vectores4();
            v4.cargar();
            v4.ordenarAlfabeticamente();
            v4.mostrarAlf();
            v4.ordenarNumericamente();
            v4.mostrarNum();
            Console.ReadKey();
        }
    }
}
