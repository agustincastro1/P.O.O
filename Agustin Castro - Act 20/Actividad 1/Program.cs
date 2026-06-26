using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
Una aerolínea administra los vuelos programados mediante un sistema orientado a objetos.
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
        public int duracionHoras
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
    }
    class VueloInternacional : Vuelo
    {
        private string PaisDestino;

        public VueloInternacional(string PD, string D, int NV, int DH)
        {

            PaisDestino = PD;
            destino = D;
            numeroVuelo = NV;
            duracionHoras = DH;
        }
        static void Main(string[] args)
        {
            List<VueloInternacional> VuelosInter = new List<VueloInternacional>();
            for (int i = 0; i < 5; i++)
            {
            Console.WriteLine("Ingrese el N° de vuelo:");
            int NV = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el destino:");
            string D = Console.ReadLine();

            Console.WriteLine("Ingrese la duracion en horas de su viaje");
            int DH = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese a que pais viaja");
            string PD = Console.ReadLine();

            VueloInternacional nuevoVuelo = new VueloInternacional(PD, D, NV, DH);
            VuelosInter.Add(nuevoVuelo);

            }
            int mayor = VuelosInter[0].duracionHoras;
            foreach (VueloInternacional V in VuelosInter)
            {
                if (V.duracionHoras > mayor)
                {
                    mayor = V.duracionHoras;
                    Console.WriteLine($"El vuelo: {V.numeroVuelo} tiene mayor duracion.");
                }
            }
            foreach (VueloInternacional V in VuelosInter)
            {
                Console.WriteLine($"Vuelo N°: {V.numeroVuelo} | Destino: {V.destino} | Duracion: {V.duracionHoras} | Pais: {V.PaisDestino}");
                if (V.duracionHoras == mayor)
                {
                    mayor = V.duracionHoras;
                    Console.WriteLine($"El vuelo: {V.numeroVuelo} tiene mayor duracion.");
                }
            }
            Console.ReadKey();
        }
    }
}
