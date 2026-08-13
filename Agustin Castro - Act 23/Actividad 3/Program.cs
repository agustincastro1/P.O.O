using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
    3-
Un centro de conservación marina registra de forma dinámica las especies de
mamíferos marinos divisadas en la costa para su posterior análisis estadístico.
 Crear la clase MonitoreoCostero que contenga como atributo privado
una lista de cadenas de texto List<string> especiesDetectadas.
 Métodos en MonitoreoCostero:
1. CargarAvistamientos(): Solicitar por teclado nombres de
especies marinas avistadas (ej: "Ballena Franca", "Lobo Marino",
"Delfín") y agregarlos a la lista utilizando .Add(). La carga finaliza
cuando el usuario ingresa la palabra "FIN".
2. MostrarReporteOrdenado(): Imprimir la lista de avistamientos
organizada alfabéticamente de la A a la Z utilizando el método
.Sort().
3. MostrarReporteInvertido(): Imprimir la lista organizada de la
Z a la A combinando .Sort() con el método .Reverse().
4. BuscarEspecie(): Pedir al operador que ingrese el nombre de un
animal y, utilizando los métodos de búsqueda de listas, informar si la
especie fue divisada en la costa durante el día. 
    */
    class MonitoreoCostero
    {
        private List<string> especiesDestacada = new List<string>();

        public void CargarAvistamientos()
        {
            while (true)
            {
                string linea;
                Console.WriteLine("ingrese el nombre de la especie del animal visto, para dejar de agragar animales ingrese 'FIN':");
                linea = Console.ReadLine();
                if (linea == "FIN")
                {
                    Console.WriteLine("Carga de especies finalizada");
                    break;
                }
                especiesDestacada.Add(linea);
            }
        }

        public void MostrarReporteOrdenado()
        {
            Console.WriteLine("Lista de avistamientos");
            especiesDestacada.Sort();
            foreach (string animal in especiesDestacada)
            {
                Console.WriteLine("- "+animal);
            }
        }
        public void MostrarReporteInvertido()
        {
            Console.WriteLine("Lista de avistamientos");
            especiesDestacada.Reverse();
            foreach (string animal in especiesDestacada)
            {
                Console.WriteLine("- "+ animal);
            }
        }

        public void BuscarEspecie()
        {
            Console.WriteLine("Ingrese la especie que quiere buscar:");
            string linea = Console.ReadLine();
            bool encontro = false;
            foreach (string animal in especiesDestacada)
            {
                if (animal == linea)
                {
                    Console.WriteLine($"La especie {animal} fue vista hoy");
                    encontro = true;
                    break;
                }
            }
                if (encontro == false)
                { 
                    Console.WriteLine($"la especie {linea} no fue vista hoy. ");
                }
        }
        static void Main(string[] args)
        {
            MonitoreoCostero MC = new MonitoreoCostero();
            while (true)
            {
                string linea;
                int eleccion;
                Console.WriteLine("Eliga una opcion escribiendo su numero:");
                Console.WriteLine("1. Cargar avistamientos | 2. Mostrar reportes ordenados | 3. Mostrar reportes ordenados al reves | 4. buscar especie | 5. terminar programa");

                linea = Console.ReadLine();
                eleccion = int.Parse(linea);

                if (eleccion == 1)
                {
                    Console.Clear();
                    MC.CargarAvistamientos();
                    Console.WriteLine("Avistamiento Cargado.");
                }
                if (eleccion == 2)
                {
                    Console.Clear();
                    MC.MostrarReporteOrdenado();
                }
                if (eleccion == 3)
                {
                    Console.Clear();
                    MC.MostrarReporteInvertido();
                }
                if (eleccion == 4)
                {
                    Console.Clear();
                    MC.BuscarEspecie();
                }
                if (eleccion == 5)
                {
                    Console.Clear();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}




