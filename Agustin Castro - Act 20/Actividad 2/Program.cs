using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
Problema:
Una empresa de envíos desea registrar sus entregas mediante colaboración de
clases.
Crear una clase Paquete con propiedades: código, peso y destino. Crear una clase
Despachador que contenga una lista de paquetes y un método para registrar nuevos
paquetes.
Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
 Todos los paquetes registrados.
 Cuántos superan los 10 kg de peso.
 Cuántos tienen destino nacional (por ejemplo, “Argentina”). 
    */
    class Paquete
    {
        private int Codigo;
        private float Peso;
        private string Destino;

        public int codigo
        {
            set
            {
                Codigo = value;
            }
            get
            {
                return Codigo;
            }
        }
        public float peso
        {
            set
            {
                Peso = value;
            }
            get
            {
                return Peso;
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
        public Paquete()
        {
            string linea;
            Console.WriteLine("Ingrese el codigo del paquete:");
            linea = Console.ReadLine();
            Codigo = int.Parse(linea);

            Console.WriteLine("Ingrese el Peso del paquete en Kg:");
            linea = Console.ReadLine();
            Peso = int.Parse(linea);

            Console.WriteLine("Ingrese el destino del paquete:");
            Destino = Console.ReadLine();
        }
    }
    class Despachador
    {

        List<Paquete> paquetes = new List<Paquete>();

        public void CargarNuevoPaquete()
        {
            Paquete nuevoPaquete = new Paquete();
            paquetes.Add(nuevoPaquete);
        }
        public List<Paquete> Paquetes
        {
            set { paquetes = value; }
            get { return paquetes;  }
        }
        static void Main(string[] args)
        {
            Despachador D = new Despachador();
            D.CargarNuevoPaquete();
            D.CargarNuevoPaquete();
            D.CargarNuevoPaquete();
            D.CargarNuevoPaquete();
            D.CargarNuevoPaquete();
            foreach (Paquete P in D.Paquetes)
            {
                Console.WriteLine($"Codigo del paquete: {P.codigo} Peso: {P.peso} Destino: {P.destino}");
            }
            foreach (Paquete P in D.Paquetes)
            {
                if (P.peso > 10)
                {
                    Console.WriteLine($"El paquete: {P.codigo} tiene un peso mayor a 10Kg");
                }
                if (P.destino == "Argentina")
                {
                    Console.WriteLine($"El paquete: {P.codigo} tiene un destino nacional");
                }
            }
        }
    }
}
