using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
     Logística de Puerto Espacial
Una estación de acoplamiento registra el peso de los contenedores transportados en las
bodegas de carga de las naves espaciales que llegan al puerto.
● Crear la clase NaveEspacial que contenga únicamente el atributo privado
NombreNave y su constructor para cargarlo.
● Crear la clase colaboradora PuertoControl que contenga:
○ Un vector de 3 objetos de la clase NaveEspacial.
○ Una matriz irregular de tipo double llamado pesoContenedores, donde
cada fila representa a una nave, el tamaño de la fila es la cantidad de
bodegas que posee esa nave, y los valores almacenados son los pesos (en
toneladas) de los contenedores que transporta cada bodega.

En PuertoControl, definir los siguientes métodos:

1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
irregular) y cargue el peso del contenedor asignado a cada bodega.
2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
espacial.
3. Un método que identifique e informe qué nave transporta el contenedor individual
más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
irregular).
4. Un método que indique el nombre de la nave que transporta menor peso acumulado
total (la suma de todos sus contenedores).
     */
    class naveEspacial
    {
        private string nombreNave;
        public naveEspacial()
        {
            Console.WriteLine("Ingrese el nombre de la nave: ");
            nombreNave = Console.ReadLine();
        }
        public string retornarNombre()
        {
            return nombreNave;
        }
    }
    class PuertoControl
    {
        private naveEspacial[] naves = new naveEspacial[3];
        private double[][] pesoContenedores;
        public PuertoControl()
        {
            pesoContenedores = new double[3][];
            for (int i = 0; i < naves.Length; i++)
            {
                naves[i] = new naveEspacial();
                Console.WriteLine("Ingrese la cantidad de bodegas:");
                int cantidadBodegas = int.Parse(Console.ReadLine());

                pesoContenedores[i] = new double[cantidadBodegas];

                for (int j = 0; j < cantidadBodegas; j++)
                {
                    Console.WriteLine("Ingrese el peso del contenedor asignado a la bodega " + (j + 1) + " de la nave " + naves[i].retornarNombre() + ": ");
                    pesoContenedores[i][j] = double.Parse(Console.ReadLine());
                }
            }
        }
        public void mostrarDetallePesos()
        {
            for (int i = 0; i < naves.Length; i++)
            {
                Console.WriteLine("Nave: " + naves[i].retornarNombre());

                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    Console.WriteLine("Bodega " + (j + 1) + ": " + pesoContenedores[i][j] + " toneladas");
                }
            }
        }
        public void contenedorMasPesado()
        {
            double maxPeso = pesoContenedores[0][0];
            string nombreNaveMaxPeso = naves[0].retornarNombre();
            for (int i = 0; i < naves.Length; i++)
            {
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    if (pesoContenedores[i][j] > maxPeso)
                    {
                        maxPeso = pesoContenedores[i][j];
                        nombreNaveMaxPeso = naves[i].retornarNombre();
                    }
                }
            }
            Console.WriteLine("El contenedor más pesado es de la nave: " + nombreNaveMaxPeso + " con un peso de: " + maxPeso + " toneladas");
        }
        public void naveMenorPesoAcumulado()
        {
            double[] pesoNaves = new double[naves.Length];
            for (int i = 0; i < naves.Length; i++)
            {
                double pesoAcumulado = 0;
                for (int j = 0; j < pesoContenedores[i].Length; j++)
                {
                    pesoAcumulado = pesoAcumulado + pesoContenedores[i][j];
                }
                pesoNaves[i] = pesoAcumulado;
            }
            double minPeso = pesoNaves[0];
            string nombreNaveMinPeso = naves[0].retornarNombre();
            for (int i = 0; i < naves.Length; i++)
            {
                if (pesoNaves[i] < minPeso)
                {
                    minPeso = pesoNaves[i];
                    nombreNaveMinPeso = naves[i].retornarNombre();
                }
            }
            Console.WriteLine("La nave que transporta el menor peso acumulado es: " + nombreNaveMinPeso + " con un peso de: " + minPeso + " toneladas");
        }
        static void Main(string[] args)
        {
            PuertoControl puerto = new PuertoControl();
            puerto.mostrarDetallePesos();
            puerto.contenedorMasPesado();
            puerto.naveMenorPesoAcumulado();
            Console.ReadKey();
        }
    }
}