using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*  3- Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
        cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
        etc.)*/
    class Matrices3
    {
        private int[,] matriz;
        private int Sup_izquierda;
        private int Sup_derecha;
        private int Inf_izquierda;
        private int Inf_derecha;
        public void cargar()
        {
            Console.WriteLine("ingrese un numero de filas: ");
            string linea;
            linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.WriteLine("ingrese un numero de columnas: ");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            matriz = new int[filas, columnas];

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
        public void vertices()
        {
            int filas = matriz.GetLength(0);
            int columnas = matriz.GetLength(1);

            Sup_izquierda = matriz[0, 0];
            Sup_derecha = matriz[0, columnas - 1];
            Inf_izquierda = matriz[filas - 1, 0];
            Inf_derecha = matriz[filas - 1, columnas - 1];
        }

        public void mostrar()
        {
            Console.WriteLine("El valor del vértice superior izquierdo es: " + Sup_izquierda);
            Console.WriteLine("El valor del vértice superior derecho es: " + Sup_derecha);
            Console.WriteLine("El valor del vértice inferior izquierdo es: " + Inf_izquierda);
            Console.WriteLine("El valor del vértice inferior derecho es: " + Inf_derecha);
        }

        static void Main(string[] args)
        {
            Matrices3 m3 = new Matrices3();
            m3.cargar();
            m3.vertices();
            m3.mostrar();
            Console.ReadKey();
        }
    }
}
