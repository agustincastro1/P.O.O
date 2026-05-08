using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
        3. Confeccionar una clase para administrar los días que han faltado los 3 empleados de una empresa.
        Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz irregular para cargar los días que han faltado cada empleado (cargar el número de día que faltó)
        Cada fila de la matriz representa los días de cada empleado.
        a. Mostrar los empleados con la cantidad de inasistencias.
        b. Cuál empleado faltó menos días.
     */
    class MatrizDent3
    {
        private string[] empleados;
        private int[][] faltas;
        private int[] sumaFaltas;

        public void cargarNombres()
        {
            empleados = new string[3];
            string linea;
            for (int i = 0; i < empleados.Length; i++) 
            {
                Console.WriteLine("ingrese el nombre de un empleado");
                linea = Console.ReadLine();
                empleados[i] = linea;
            }
        }

        public void cargarNotas()
        {
            string linea;
            faltas = new int[3][];
            faltas[0] = new int[3];
            faltas[1] = new int[2];
            faltas[2] = new int[5];
            for (int i = 0;i < faltas.Length; i++)
            {
                for (int j = 0;j < faltas[i].Length; j++)
                {
                    Console.WriteLine("ingrese el dia que faltó " + empleados[i]);
                    linea = Console.ReadLine();
                    faltas[i][j] = int.Parse(linea);
                }
            }
        }

        public void mostrarCantAsist()
        {
            
            Console.WriteLine("Empleados y sus faltas: ");
            sumaFaltas = new int[3];
            for (int i = 0;i < faltas.GetLength(0) ; i++)
            {
                sumaFaltas[i] = faltas[i].Length; 
            }
            for (int i = 0; i < faltas.GetLength(0) ; i++)
            {
                Console.WriteLine(empleados[i] + " cantidad de faltas: " + sumaFaltas[i]);
            }
        }

        public void mostrarMenosInasist()
        {
            string menosInasist = empleados[0];
            int menosInasist2 = sumaFaltas[0];
            for (int i = 0; i < sumaFaltas.Length - 1; i++)
            {
                if (sumaFaltas[i] > sumaFaltas[i + 1])
                {
                    menosInasist = empleados[i + 1];
                    menosInasist2 = sumaFaltas[i + 1];
                }
            }
            Console.WriteLine("el empleado con menos faltas es: " + menosInasist + " con: " + menosInasist2 + " faltas.");
        }
        static void Main(string[] args)
        {
            MatrizDent3 MD3 = new MatrizDent3();
            MD3.cargarNombres();
            MD3.cargarNotas();
            MD3.mostrarCantAsist();
            MD3.mostrarMenosInasist();
            Console.ReadKey();
        }
    }
}
