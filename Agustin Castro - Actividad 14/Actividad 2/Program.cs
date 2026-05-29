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
            string linea;
            Console.WriteLine("Ingrese un Nombre: ");
            linea = Console.ReadLine();
            Nombre = linea;

            Console.WriteLine("Ingrese un DNI: ");
            linea = Console.ReadLine();
            DNI = int.Parse(linea);

            Console.WriteLine("Ingrese el peso en KG de una maleta: ");
            linea = Console.ReadLine();
            EquipajeKilos = float.Parse(linea);
        }

        public string retornarNomrbe()
        {
            return Nombre;
        }

        public int retronarDNI()
        {
            return DNI;
        }

        public float retornarPeso()
        {
            return EquipajeKilos;
        }
    }

    class Vuelo
    {
        private Pasajero[] Pasajeros;
        public Vuelo()
        {
            Pasajeros = new Pasajero[4];
            for (int i = 0; i < 4; i++)
            {
                Pasajeros[i] = new Pasajero();
            }
        }

        public void datosPasajeros()
        {
            Console.WriteLine("Todos los datos de los pasajeros");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Nombre: " + Pasajeros[i].retornarNomrbe() + " DNI: " + Pasajeros[i].retronarDNI() + " Peso del equipaje: " + Pasajeros[i].retornarPeso());
            }
        }

        public void pesoEquipaje()
        {
            float pesoTotal = 0;
            for(int i = 0;i < 4; i++)
            {
                pesoTotal = pesoTotal + Pasajeros[i].retornarPeso(); 
            }
            Console.WriteLine("El peso total que lleva el avion con los equipajes es: " + pesoTotal);
        }

        public void limitePeso()
        {
            for (int i = 0; i < 4; i++)
            {
                if (Pasajeros[i].retornarPeso() > 23)
                {
                    Console.WriteLine("El pasajero " + Pasajeros[i].retornarNomrbe() + " con DNI " + Pasajeros[i].retronarDNI() + " Exede el limite de peso del equipaje");
                }
            }
        }

        static void Main(string[] args)
        {
            Vuelo v = new Vuelo();
            v.datosPasajeros();
            v.pesoEquipaje();
            v.limitePeso();
            Console.ReadKey();
        }
    }
}
