using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*  1- Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
        componentes por columna (es decir primero ingresar toda la primer
        columna, luego la segunda columna y así sucesivamente)
        Imprimir luego la matriz.*/
    class Matricres1
    {
        private int[,] Matriz;
        
        public void cargar()
        {
            Matriz = new int[2, 5];
            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.WriteLine("ingrese un componente");
                    string linea;
                    linea = Console.ReadLine();
                    Matriz[f,c] = int.Parse(linea);
                }
            }
        }

        public void mostrar()
        {
            for(int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(Matriz[f, c] + " ");
                }
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {
            Matricres1 m1 = new Matricres1();
            m1.cargar();
            m1.mostrar();
            Console.ReadKey();
        }
    }
}
