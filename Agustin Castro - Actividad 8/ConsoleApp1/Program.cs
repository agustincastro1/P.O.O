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

         static void Main(string[] args)
        {

            Console.ReadKey();
        }
    }
}

