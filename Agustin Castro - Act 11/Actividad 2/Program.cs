using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    class MatrizDent2
    {

        /*
            2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la primer fila, 
               2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
               (crearla sin la intervención del operador)
               Realizar la carga por teclado e imprimir posteriormente.
        */

        private int[][] matriz;
        public void cargar()
        {
            matriz = new int[5][];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                matriz[i] = new int[i + 1];
            }

            for (int f = 0; f < matriz.GetLength(0); f++)
            {

            }
        }
        static void Main(string[] args)
        {
        }
    }
}
