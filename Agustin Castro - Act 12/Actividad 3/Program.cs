using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
     3. Academia de Gastronomía: Recetario Dinámico
        Un chef instructor evalúa a 3 alumnos en un examen final. 
        Cada alumno debe presentar una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
            ● Definir un vector para los nombres de los alumnos.
            ● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato presentado.
                ● Métodos:
                    1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos de cada alumno.
                    2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
                    3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
                    4. Calcular el puntaje promedio de cada alumno e informar si está "Aprobado" (promedio >= 70) o "Reprobado".
                    5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el valor máximo de la matriz).
     */
    class Act3
    {
        private string[] alumnos;
        private int[][] notas;
        private int nota;
        private int[] promedioNota;

        public void cargarNombres()
        {
            string linea;
            notas = new int[3][];
            notas[0] = new int[2];
            notas[1] = new int[4];
            notas[2] = new int[3];
            alumnos = new string[3];
            for (int i = 0; i < alumnos.Length; i ++)
            {
                Console.WriteLine("Ingrese el nombre del alumno");
                linea = Console.ReadLine();
                alumnos[i] = linea;
            }
        }

        public void cargarPuntajes()
        {
            string linea;
            for (int i = 0; i < notas.GetLength(0); i++)
            { 
                for (int j = 0; j < notas[i].GetLength(0); j++)
                {
                    Console.WriteLine("ingrese los puntajes del plato de "  + alumnos[i] + ":");
                    linea = Console.ReadLine();
                    nota = int.Parse(linea);
                    if (nota >= 0 && nota <= 100)
                    {
                        notas[i][j] = nota;
                    }
                    else
                    {
                        Console.WriteLine("ingrese un numero entre 1 y 100");
                        i--;
                    }
                }
            }
        }

        public void mostrar()
        {
            Console.WriteLine("Notas de los alumnos");
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write(alumnos[i] + ": ");
                for (int j = 0; j < notas[i].GetLength(0); j++)
                {
                    Console.Write(notas[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void promedio()
        {
            int suma = 0;
            promedioNota = new int[alumnos.Length];
            for (int i = 0; i < alumnos.Length; i++)
            {
                for (int j = 0; j < notas[i].GetLength(0); j++)
                {
                    suma = suma + notas[i][j];
                }
                promedioNota[i] = suma / notas[i].GetLength(0);
            }

            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("Promedio de: " + alumnos[i] + " " + promedioNota[i]);
                if (promedioNota[i] < 70)
                {
                    Console.WriteLine("esta reprobado");
                }
                else
                {
                    Console.WriteLine("esta aprobado");
                }
            }
        }

        public void notaMasAlta()
        {
            int notaAlta = notas[0][0];
            int aux;
            int posicion = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {
                for (int j = 0; j < notas[i].GetLength(0) - 1; j++)
                {
                    if (notaAlta > notas[i][j + 1])
                    {
                        aux = notaAlta;
                        notaAlta = notas[i][j + 1];
                        notas[i][j + 1] = aux;
                        posicion = i;
                    }
                }
            }
            Console.WriteLine("el alumno con el puntaje mas alto es: " + alumnos[posicion]);
        }

        static void Main(string[] args)
        {
            Act3 A3 = new Act3();
            A3.cargarNombres();
            A3.cargarPuntajes();
            A3.mostrar();
            A3.promedio();
            A3.notaMasAlta();
            Console.ReadKey();
        }
    }
}
