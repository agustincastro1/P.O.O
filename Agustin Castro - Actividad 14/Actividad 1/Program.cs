using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
        1. El Sistema de Peaje.
           Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
           La clase Vehiculo debe tener los siguientes atributos privados:
           Patente (de tipo string).
           Tipo (puede ser "Auto", "Camion" o "Moto").
           Tarifa (un valor decimal que representa el costo de su pase).
           El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
           La clase CabinaPeaje debe tener como atributos privados:
           El número o identificador de la cabina.
           Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
           Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos.
           Además, implementar los siguientes métodos dentro de CabinaPeaje:
           Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
           Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
           Un método que muestre la patente del vehículo que pagó la tarifa más cara.
    */
    class Vehiculo
    {

        private string patente;
        private string tipo;
        private float tarifa;

        public Vehiculo()
        {
            string linea;
            Console.WriteLine("ingrese la patente de su vehiculo");
            linea = Console.ReadLine();
            patente = linea;

            Console.WriteLine("ingrese el tipo de vehiculo que tiene (Auto, Camion o Moto)");
            linea = Console.ReadLine();
            tipo = linea;

            Console.WriteLine("ingrese la tarifa del costo de su pase");
            linea = Console.ReadLine();
            tarifa = float.Parse(linea);
        }

        public string retornarPatente()
        {
            return patente;
        }

        public string returnarTipo()
        {
            return tipo;
        }

        public float returnarTarifa()
        {
            return tarifa;
        }
    }

    class CabinaPeaje
    {
        private Vehiculo vehiculo1, vehiculo2, vehiculo3;
        private int numeroCabina;
        private float recaudacionTotal; 

        CabinaPeaje()
        {
            string linea;
            Console.WriteLine("ingrese el numero de la cabina");
            linea= Console.ReadLine();
            numeroCabina = int.Parse(linea);

            vehiculo1 = new Vehiculo();
            vehiculo2 = new Vehiculo();
            vehiculo3 = new Vehiculo();
        }
        
        public void imprimirPatentes()
        {
            Console.WriteLine("/---------------------------------------------------/");
            Console.WriteLine("Patente 1: " + vehiculo1.retornarPatente() + " tipo: " + vehiculo1.returnarTipo() + " Cabina N°: " + numeroCabina);
            Console.WriteLine("Patente 2: " + vehiculo2.retornarPatente() + " tipo: " + vehiculo2.returnarTipo() + " Cabina N°: " + numeroCabina);
            Console.WriteLine("Patente 3: " + vehiculo3.retornarPatente() + " tipo: " + vehiculo3.returnarTipo() + " Cabina N°: " + numeroCabina);
        }

        public void recaudacionTarifas()
        {
            recaudacionTotal = vehiculo1.returnarTarifa() + vehiculo2.returnarTarifa() + vehiculo3.returnarTarifa();
            Console.WriteLine("la recaudacion total de todas las patentes es: " + recaudacionTotal);
        }

        public void tarifaCara()
        {
            float mayorTarifa = vehiculo1.returnarTarifa();
            string patenteMayorTarifa = vehiculo1.retornarPatente();

            if (mayorTarifa < vehiculo2.returnarTarifa())
            {
                mayorTarifa = vehiculo2.returnarTarifa();
                patenteMayorTarifa = vehiculo2.retornarPatente();
            }
            if (mayorTarifa < vehiculo3.returnarTarifa())
            {
                mayorTarifa = vehiculo3.returnarTarifa();
                patenteMayorTarifa = vehiculo3.retornarPatente();
            }

            Console.WriteLine("La patente que mayor tarifa pagó es: " + patenteMayorTarifa);
        }

        static void Main(string[] args)
        {
            CabinaPeaje C1 = new CabinaPeaje();
            CabinaPeaje C2 = new CabinaPeaje();
            CabinaPeaje C3 = new CabinaPeaje();
            C1.imprimirPatentes();
            C1.recaudacionTarifas();
            C1.tarifaCara();
            C2.imprimirPatentes();
            C2.recaudacionTarifas();
            C2.tarifaCara();
            C3.imprimirPatentes();
            C3.recaudacionTarifas();
            C3.tarifaCara();
            Console.ReadKey();
        }
    }
}
