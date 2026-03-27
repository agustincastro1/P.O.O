using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4. Se cuenta con la siguiente información:
            ● Las edades de 20 estudiantes del turno mañana.
            ● Las edades de 30 estudiantes del turno tarde.
            ● Las edades de 15 estudiantes del turno noche.
            Las edades de cada estudiante deben ingresarse por teclado.
            a) Obtener el promedio de las edades de cada turno (tres promedios)
            b) Imprimir dichos promedios (promedio de cada turno)
            c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            promedio de edades menor. */

            int turnoMañana = 0, turnoTarde = 0, turnoNoche = 0, promedioMañana = 0, promedioTarde = 0, promedioNoche = 0, suma = 0;
            string linea;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Escriba la edad de un alumno del turno mañana: ");
                linea = Console.ReadLine();
                turnoMañana = int.Parse(linea);
                suma = suma + turnoMañana;
            }
            promedioMañana = suma / 20;
            suma = 0;
            for (int i = 0; i < 30; i++)
            {
                Console.WriteLine("Escriba la edad de un alumno del turno tarde: ");
                linea = Console.ReadLine();
                turnoTarde = int.Parse(linea);
                suma = suma + turnoTarde;
            }
            promedioTarde = suma / 30;
            suma = 0;
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("Escriba la edad de un alumno del turno noche: ");
                linea = Console.ReadLine();
                turnoNoche = int.Parse(linea);
                suma = suma + turnoNoche;
            }
            promedioNoche = suma / 15;

            Console.WriteLine("Promedio edad turno mañana: " + promedioMañana);
            Console.WriteLine("Promedio edad turno tarde: " + promedioTarde);
            Console.WriteLine("Promedio edad turno noche: " + promedioNoche);

            if(promedioMañana < promedioTarde && promedioMañana < promedioNoche)
            {
                Console.WriteLine("El turno mañana tiene un menor promedio de edad.");
            }
            if (promedioMañana > promedioTarde && promedioTarde < promedioNoche)
            {
                Console.WriteLine("El turno tarde tiene un menor promedio de edad.");
            }
            if (promedioNoche < promedioTarde && promedioMañana > promedioNoche)
            {
                Console.WriteLine("El turno Noche tiene un menor promedio de edad.");
            }
            Console.ReadKey();
        }
    }
}
