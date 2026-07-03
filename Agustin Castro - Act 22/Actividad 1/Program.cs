using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
     Crear una clase ClaseGimnasio con atributos: nombreClase, horaInicio y horaFin (usar
DateTime).
 Implementar un constructor que permita cargar los datos desde consola y otro
que cargue valores por defecto (sobrecarga de constructores).
 Incluir un método para calcular la duración de la clase usando TimeSpan.
 Crear un vector de 3 clases de gimnasio y mostrar:
1. La clase que tenga la mayor duración.
2. El nombre y el horario de inicio de la clase más temprana.
     */
    class ClaseGimnasio
    {
        private string nombreClase;
        private DateTime horaInicio;
        private DateTime horaFin;

        public ClaseGimnasio()
        {
            Console.WriteLine("Ingrese el nombre de la clase:");
            nombreClase = Console.ReadLine();
            Console.WriteLine("Ingrese la hora de inicio (Hora:Minutos):");
            horaInicio = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la hora de fin (Hora:Minutos):");
            horaFin = DateTime.Parse(Console.ReadLine());
        }

        public ClaseGimnasio(string nombre, DateTime inicio, DateTime fin)
        {
            nombreClase = nombre;
            horaInicio = inicio;
            horaFin = fin;
        }

        public TimeSpan CalcularDuracion()
        {
            TimeSpan duracion = horaFin - horaInicio;
            Console.WriteLine($"Duración de la clase {nombreClase}: {duracion}");
            return duracion;
        }


        static void Main(string[] args)
        {
            ClaseGimnasio[] clases = new ClaseGimnasio[3];
            clases[0] = new ClaseGimnasio();
            clases[1] = new ClaseGimnasio("Yoga", new DateTime(2026, 6, 1, 8, 0, 0), new DateTime(2026, 6, 1, 9, 0, 0));
            clases[2] = new ClaseGimnasio("Spinning", new DateTime(2026, 6, 1, 10, 0, 0), new DateTime(2026, 6, 1, 11, 0, 0));

            TimeSpan duracionMayor = clases[0].CalcularDuracion();
            ClaseGimnasio mayorDuracion = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                TimeSpan duracionActual = clases[i].CalcularDuracion();
                if (duracionActual > duracionMayor)
                {
                    duracionMayor = duracionActual;
                    mayorDuracion = clases[i];
                }
            }

            Console.WriteLine($"La clase de mayor duración es: {mayorDuracion.nombreClase} ({duracionMayor})");

            Console.WriteLine("--------------------------------------------------");

            ClaseGimnasio masTemprana = clases[0];

            for (int i = 1; i < clases.Length; i++)
            {
                if (clases[i].horaInicio < masTemprana.horaInicio)
                {
                    masTemprana = clases[i];
                }
            }

            Console.WriteLine($"La clase más temprana es: {masTemprana.nombreClase} a las {masTemprana.horaInicio:HH:mm}");
            Console.ReadKey();
        }
    }
}
