using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Actividad_2
{
    /*
    2-
Una empresa de logística autónoma monitorea el estado y nivel de batería de sus
drones de entrega en vuelo de regreso a la base.
 Crear la clase Dron que contenga los atributos privados: codigo (string) y
nivelBateria (int, de 0 a 100). Definir sus propiedades correspondientes.
Su constructor debe recibir cod y bat.
 Crear la clase CentroControl que administre una lista de objetos
List<Dron>.
 Métodos en CentroControl:

1. Un constructor que cargue por teclado una lista inicial de 4 drones
ingresando sus códigos y baterías.
2. ListarFlota(): Mostrar la lista de drones en pantalla.
3. RemoverDronesBajos(): Recorrer la lista y remover por
completo de la flota a todos aquellos drones cuyo nivel de batería
sea menor o igual al 15% (ya que requieren mantenimiento
automático urgente).
4. MostrarDronesRestantes(): Imprimir la flota actualizada y la
cantidad de drones operativos utilizando la propiedad .Count.
    */
    class Dron
    {
        private string codigo;
        private int nivelBateria;

        public string Codigo
        {
            set
            {
                codigo = value;
            }
            get
            {
                return codigo;
            }
        }
        public int NivelBateria
        {
            set
            {
                nivelBateria = value;
            }
            get
            {
                return nivelBateria;
            }
        }

        public Dron(string cod, int bat)
        {
            Codigo = cod;
            NivelBateria = bat;
        }
    }
    class control
    {
        List<Dron> drones = new List<Dron>();

        public control()
        {
            for (int i = 0; i < 4; i++)
            {
                int bat = 0;
                string linea;
                Console.WriteLine("Nuevo Dron");
                Console.WriteLine("Ingrese el codigo del Dron");
                string cod = Console.ReadLine();
                for (int j = 0; j < 1; j++)
                {
                    Console.WriteLine("Ingrese el nivel de bateria del Dron (0 - 100)");
                    linea = Console.ReadLine();
                    if (int.Parse(linea) >= 0 && int.Parse(linea) <= 100)
                    {
                        bat = int.Parse(linea);
                    }
                    else
                    {
                        Console.WriteLine("el nivel de bateria tiene que ser entre 0 y 100");
                        j--;
                    }
                }


                Dron dron = new Dron(cod, bat);

                drones.Add(dron);
                Console.WriteLine("Dron agregado");
            }
        }

        public void listaFlota()
        {
            Console.WriteLine("LISTA DE DRONES:");
            foreach (Dron dron in drones)
            {
                Console.WriteLine($"Codigo del dron: {dron.Codigo}");
                Console.WriteLine($"nivel de bateria: {dron.NivelBateria}");
                Console.WriteLine("------------------------------------------------");
            }
        }

        public void RemoverDronesBajos()
        {
            for (int i = drones.Count - 1; i >= 0; i--)
            {
                if (drones[i].NivelBateria <= 15)
                {
                    Console.WriteLine($"El dron {drones[i].Codigo} necesita mantenimiento, sera retirado de la flota");
                    drones.Remove(drones[i]);
                }
            }
        }

        public void MostrarDronesRestantes()
        {
            Console.WriteLine($"Lista de drones ({drones.Count}):");
            foreach (Dron dron in drones)
            {
                Console.WriteLine($"Codigo del dron: {dron.Codigo}");
                Console.WriteLine($"Nivel de bateria del dron: {dron.NivelBateria}");
                Console.WriteLine("------------------------------------------------");
            }
        }

        static void Main(string[] args)
        {
            control C = new control();
            while (true)
            {
                string linea;
                int eleccion;
                Console.WriteLine("Eliga una opcion escribiendo su numero:");
                Console.WriteLine("1. Mostrar lista de drones | 2. Remover drones bajos | 3. Mostrar lista de drones activos | 4. cerrar control de drones");

                linea = Console.ReadLine();
                eleccion = int.Parse(linea);

                if (eleccion == 1)
                {
                    Console.Clear();
                    C.listaFlota();
                    Console.WriteLine("Documento agregado.");
                }
                if (eleccion == 2)
                {
                    Console.Clear();
                    C.RemoverDronesBajos();
                }
                if (eleccion == 3)
                {
                    Console.Clear();
                    C.MostrarDronesRestantes();
                }
                if (eleccion == 4)
                {
                    Console.Clear();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
