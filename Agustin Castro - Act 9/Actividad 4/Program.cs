using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    class Vectores4
    {
        /*
          4. Se realiza una evaluación a 6 docentes por parte de sus alumnos. Se registran
             sus nombres y puntajes promedio obtenidos (de 1 a 10).
             Cargar sus datos en vectores paralelos, mostrar docente con calificación más
             alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
             calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
             desaprobaron (tomando como base que se aprueba con una nota mayor o igual a 6)
         */
        private string[] docentes;
        private int[] calificaciones;
        private string calificacionAlta;
        private string calificacionBaja;
        private int aprobados = 0;
        private int desaprobados = 0;

        public void cargar()
        {
            docentes = new string[6];
            calificaciones = new int[6];
            for (int i = 0; i < docentes.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del docente:");
                string linea;
                linea = Console.ReadLine();
                docentes[i] = linea;
                Console.WriteLine("ingrese la calificacion del docente:");
                linea = Console.ReadLine();
                calificaciones[i] = int.Parse(linea);
            }
        }

        public void calcular()
        {
            for (int i = 0; i < calificaciones.Length; i++)
            {
                for (int j = 0; j < calificaciones.Length - i - 1; j++)
                {
                    if (i != 5)
                    {
                        if (calificaciones[j] > calificaciones[j + 1])
                        {
                            int aux;
                            string auxDoc;
                            aux = calificaciones[j];
                            auxDoc = docentes[j];
                            docentes[j] = docentes[j + 1];
                            calificaciones[j] = calificaciones[j + 1];
                            docentes[j + 1] = auxDoc;
                            calificaciones[j + 1] = aux;
                        }
                    }
                }
            }
            for (int i = 0; i < calificaciones.Length; i++)
            {
                if (calificaciones[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }
            calificacionAlta = docentes[5];
            calificacionBaja = docentes[0];
        }

        public void mostrar()
        {
            Console.WriteLine("docente con calificacion mas alta: " + calificacionAlta);
            Console.WriteLine("docente con calificacion mas baja: " + calificacionBaja);
            Console.WriteLine("cantidad de docentes aprobados: " + aprobados);
            Console.WriteLine("cantidad de docentes desaprobados: " + desaprobados);
        }
        static void Main(string[] args)
        {
            Vectores4 v4 = new Vectores4();
            v4.cargar();
            v4.calcular();
            v4.mostrar();
            Console.ReadKey();
        }
    }
}
