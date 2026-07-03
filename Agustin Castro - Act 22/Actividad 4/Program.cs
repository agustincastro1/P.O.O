using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
Definir una clase Vuelo con atributos: codigo, horaSalida y horaLlegada (DateTime).
 Usar la palabra clave this en el constructor para diferenciar los parámetros de
los atributos.
 Crear un método para calcular la duración del vuelo (TimeSpan).
 Cargar un vector con 4 vuelos y mostrar:
1. El código y duración del vuelo más largo.
2. El código del vuelo que salga más temprano. 
    */
    class Vuelo
    {
        private string codigo;
        private DateTime horaSalida;
        private DateTime horaLlegada;

        public Vuelo(string codigo,DateTime horaSalida,DateTime horaLlegada)
        {
            this.codigo = codigo;
            this.horaSalida = horaSalida;
            this.horaLlegada = horaLlegada;
        }

        public TimeSpan calcularDurVuelo()
        {
            TimeSpan duracion = horaSalida - horaLlegada;
            Console.WriteLine($"Duración del vuelo {codigo}: {duracion}");
            return duracion;
        }

        static void Main(string[] args)
        {
            Vuelo[] vuelos = new Vuelo[4];
            vuelos[0] = new Vuelo("AF21", new DateTime(2026, 3, 20, 3, 0, 0), new DateTime(2026, 4, 4, 40, 0, 0));
            vuelos[1] = new Vuelo("K47", new DateTime(2026, 7, 16, 8, 0, 0), new DateTime(2026, 7, 16, 11, 0, 0));
            vuelos[2] = new Vuelo("C4", new DateTime(2026, 12, 31, 23, 0, 0), new DateTime(2027, 1, 1, 10, 0, 0));
            vuelos[2] = new Vuelo("LF21", new DateTime(2026, 1, 25, 15, 0, 0), new DateTime(2026, 1, 25, 19, 0, 0));

            TimeSpan duracionMayor = vuelos[0].calcularDurVuelo();
            Vuelo mayorDuracion = vuelos[0];

            Console.WriteLine($"El vuelo mas largo es el: {mayorDuracion.codigo} {duracionMayor}");

            Console.WriteLine("--------------------------------------------------");

            Vuelo masTemprana = vuelos[0];

            for (int i = 1; i < vuelos.Length; i++)
            {
                if (vuelos[i].horaSalida < masTemprana.horaSalida)
                {
                    masTemprana = vuelos[i];
                }
            }

            Console.WriteLine($"el vuelo que sale mas temprano es el: {masTemprana.codigo} a las {masTemprana.horaSalida:HH:mm}");
            Console.ReadKey();
        }
    }
}
