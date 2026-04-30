using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*  2- Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
        primer fila con la segunda. Imprimir luego la matriz.*/
    class Matrices2
    {
        private int[,] matriz;
        
        public void cargar()
        {
            Console.WriteLine("ingrese un numero de filas: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);
            Console.WriteLine("ingrese un numero de columnas: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);
            matriz = new int[filas,columnas];

            for (int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {
                    Console.WriteLine("ingrese un componente:");
                    linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
            }
        }

        public void mostrar()
        {
            for(int f = 0; f < matriz.GetLength(0); f++)
            {
                for (int c = 0; c < matriz.GetLength(1); c++)
                {

                }
            }
        }

        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
