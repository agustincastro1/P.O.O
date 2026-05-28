using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
        2.  Control de Vuelos
            Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg).
            En su constructor, solicitar la carga de estos tres datos.
            Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero.
            Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
            Agregar los siguientes métodos en la clase Vuelo:
            Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
            Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
            Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.

    */
    class Pasajero
    {
        private string Nombre;
        private int DNI;
        private float EquipajeKilos;

        public Pasajero()
        {

        }
    }

    class Vuelo
    {

        static void Main(string[] args)
        {
        }
    }
}
