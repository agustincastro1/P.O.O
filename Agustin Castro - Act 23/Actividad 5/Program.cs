using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5
{
    /*
    Un taller mecánico automatizado administra la recepción y egreso de automóviles
que se encuentran en el sector de reparaciones.
 Crear la clase Vehiculo que contenga como atributos privados: patente
(string) y costoReparacion (double). Definir sus propiedades
correspondientes y un constructor que reciba pat y costo.
 Crear la clase GestionTaller que administre una lista de objetos List.
 Métodos en GestionTaller:
o IngresarVehiculo(): Solicitar por teclado la patente y el costo de
reparación de un vehículo para agregarlo a la lista mediante .Add().
o BuscarVehiculo(): Pedir al operador que ingrese una patente y,
recorriendo la lista, informar si el vehículo está en el taller y mostrar
su costo asociado.
o EntregarVehiculo(): Solicitar una patente por teclado, buscar el
vehículo en la lista y, si existe, removerlo de la colección mediante
.Remove() confirmando la entrega del automóvil.

o CalcularRecaudacionPendiente(): Listar los vehículos
actualmente en reparación, la cantidad total de unidades alojadas en
el taller mediante la propiedad .Count y la suma total acumulada por
cobrar.
    */
    class Vehiculo
    {

        private string patente;
        private double costoReparacion;


        public string Patente
        {
            set
            {
                patente = value;
            }
            get
            {
                return patente;
            }
        }

        public double CostoReparacion
        {
            set
            {
                costoReparacion = value;
            }
            get
            {
                return costoReparacion;
            }
        }

        public Vehiculo(string pat, double costo)
        {
            this.patente = pat;
            this.costoReparacion = costo;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine($"Patente: {Patente} | Costo de reparación: ${CostoReparacion:F2}");
        }
    }
    class GestionTaller
    {
        // Lista de vehículos alojados en el taller
        private List<Vehiculo> listaVehiculos;

        public GestionTaller()
        {
            listaVehiculos = new List<Vehiculo>();
        }

        // 1. IngresarVehiculo(): Pide datos por teclado y agrega mediante .Add()
        public void IngresarVehiculo()
        {
            string linea;
            Console.WriteLine("Agregar Vehiculo");
            Console.Write("Ingrese la patente del vehículo: ");
            string patente = Console.ReadLine();

            Console.Write("Ingrese el costo de la reparación: ");
            linea = Console.ReadLine();
            double costo = double.Parse(linea);

            if (costo >= 0)
            {
                Vehiculo nuevoVehiculo = new Vehiculo(patente, costo);
                listaVehiculos.Add(nuevoVehiculo);
                Console.WriteLine("Vehículo ingresado correctamente al taller.");
            }
            else
            {
                Console.WriteLine("Error: Ingrese un costo numérico válido.");
            }
        }

        // 2. BuscarVehiculo(): Pide patente, recorre la lista e informa costo
        public void BuscarVehiculo()
        {
            Console.WriteLine("Buscar vehiculo");
            Console.Write("Ingrese la patente a buscar: ");
            string linea = Console.ReadLine();

            bool encontro = false;

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos[i].Patente == linea)
                {
                    Console.WriteLine($"El vehículo con patente {listaVehiculos[i].Patente} está en el taller.");
                    Console.WriteLine($"Costo asociado: ${listaVehiculos[i].CostoReparacion}");
                    encontro = true;
                    break;
                }
            }

            if (encontro == false)
            {
                Console.WriteLine($"El vehículo con patente {linea} no se encuentra en el taller.");
            }
        }

        // 3. EntregarVehiculo(): Busca por patente y remueve mediante .Remove()
        public void EntregarVehiculo()
        {
            Console.WriteLine("Entregar Vehiculo");
            Console.Write("Ingrese la patente del vehículo a entregar: ");
            string linea = Console.ReadLine();

            bool encontro = false;

            for (int i = 0; i < listaVehiculos.Count; i++)
            {
                if (listaVehiculos[i].Patente == linea)
                {
                    Console.WriteLine($"Se entregó el vehículo {listaVehiculos[i].Patente}. Removido con éxito del taller.");
                    listaVehiculos.Remove(listaVehiculos[i]);
                    encontro = true;
                    break;
                }
            }

            if (encontro == false)
            {
                Console.WriteLine($"No se pudo entregar: La patente {linea} no está registrada.");
            }
        }

        // 4. CalcularRecaudacionPendiente(): Muestra vehículos, .Count y suma acumulada
        public void CalcularRecaudacionPendiente()
        {
            Console.WriteLine("Recaudacion pendiente y estado del taller");

            if (listaVehiculos.Count > 0)
            {
                Console.WriteLine("Vehículos actualmente en reparación:");
                double recaudacionTotal = 0;

                foreach (Vehiculo v in listaVehiculos)
                {
                    v.MostrarInformacion();
                    recaudacionTotal = recaudacionTotal + v.CostoReparacion;
                }

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Total de unidades alojadas: {listaVehiculos.Count}");
                Console.WriteLine($"Suma total acumulada por cobrar: ${recaudacionTotal}");
            }
            else
            {
                Console.WriteLine("El taller se encuentra vacío actualmente.");
            }
        }
        static void Main(string[] args)
        {
            GestionTaller taller = new GestionTaller();

            while (true)
            {
                string linea;
                int eleccion;
                Console.WriteLine("Gestion del taller mecanico");
                Console.WriteLine("1. Ingresar vehículo");
                Console.WriteLine("2. Buscar vehículo");
                Console.WriteLine("3. Entregar vehículo");
                Console.WriteLine("4. Calcular recaudación pendiente");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                linea = Console.ReadLine();
                eleccion = int.Parse(linea);

                if (eleccion == 1)
                {
                    Console.Clear();
                    taller.IngresarVehiculo();
                }
                if (eleccion == 2)
                {
                    Console.Clear();
                    taller.BuscarVehiculo();
                }
                if (eleccion == 3)
                {
                    Console.Clear();
                    taller.EntregarVehiculo();
                }
                if (eleccion == 4)
                {
                    Console.Clear();
                    taller.CalcularRecaudacionPendiente();
                }
                if (eleccion == 5)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}