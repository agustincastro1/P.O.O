using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
Una aerolínea administra los vuelos programados mediante un sistema orientado a
objetos.
Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
destino y duración en horas. Luego definir una clase derivada VueloInternacional que
herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
desde consola y luego:
 Mostrar los vuelos registrados y el país de destino.
 Informar cuál es el vuelo con mayor duración.
 Mostrar el orden de ejecución de los constructores. 
    */
    class Vuelo
    {
        private int NumeroVuelo;
        private string Destino;
        private int DuracionHoras;

        public int numeroVuelo
        {
            set
            {
                NumeroVuelo = value;
            }
            get
            {
                return NumeroVuelo;
            }
        }
        public string destino
        {
            set
            {
                Destino = value;
            }
            get
            {
                return Destino;
            }
        }
        public int ducaionHoras
        {
            set
            {
                DuracionHoras = value;
            }
            get
            {
                return DuracionHoras;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
