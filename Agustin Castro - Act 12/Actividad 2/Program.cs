using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*2. Gestión de Complejo de Cine
    Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10 asientos
    la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
    ● Definir una matriz irregular de 4 filas para representar los asientos.
    ● Métodos:
        1. Inicializar la matriz con los tamaños de las salas mencionadas (sin intervención del operador).
        2. Crear un método de "Venta de Entradas" que permita cargar la edad del espectador en un asiento específico (fila y columna).
        3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador en cada asiento.
        4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
        5. Informar cuál es el promedio de edad de los espectadores de todo el complejo.
    */
    class Act2
    {
        private int[][] asientos;
        private int sala;
        private int asiento;
        private int edad;
        private int menores;

        public void CrearAsientos()
        {
            asientos = new int[4][];
            asientos[0] = new int[10];
            asientos[1] = new int[15];
            asientos[2] = new int[8];
            asientos[3] = new int[12];
        }
        
        public void VentaEntradas()
        {
            string linea;
            for (int i = 0; i < 45; i++)
            {
                Console.WriteLine("elija una sala:");
                linea = Console.ReadLine();
                sala = int.Parse(linea);

                Console.WriteLine("elija su asiento");
                linea = Console.ReadLine();
                asiento = int.Parse(linea);

                Console.WriteLine("ingrese su edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);

                asientos[sala - 1][asiento - 1] = edad;
            }
        }

        public void imprimirMapa()
        {
            Console.WriteLine("Mapa de asientos:");
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                Console.Write("fila " + i);
                for (int j = 0; j < asientos[i].GetLength(0); j++)
                {
                    Console.Write(" " + asientos[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void calcularMenores()
        {
            for (int j = 0; j < asientos[0].GetLength(0); j++)
            {
                if (asientos[0][j] !=0 && asientos[0][j] < 18)
                {
                    menores++;
                }
            }
            Console.WriteLine("en la sala 1 hay " + menores + " menor/es");
            menores = 0;
            for (int j = 0; j < asientos[1].GetLength(0); j++)
            {
                if (asientos[1][j] !=0 && asientos[1][j] < 18)
                {
                    menores++;
                }
            }
            Console.WriteLine("en la sala 2 hay " + menores + " menor/es");
            menores = 0;
            for (int j = 0; j < asientos[2].GetLength(0); j++)
            {
                if (asientos[2][j] !=0 && asientos[2][j] < 18)
                {
                    menores++;
                }
            }
            Console.WriteLine("en la sala 3 hay " + menores + " menor/es");
            menores = 0;
            for (int j = 0; j < asientos[3].GetLength(0); j++)
            {
                if (asientos[3][j] != 0 && asientos[3][j] < 18)
                {
                    menores++;
                }
            }
            Console.WriteLine("en la sala 4 hay " + menores + " menor/es");
        }

        public void promedioEdades()
        {
            int suma = 0;
            int promedio;
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int j = 0; j < asientos[i].GetLength(0); j++)
                {
                    if (asientos[i][j] != 0)
                    {
                        suma = suma + asientos[i][j];
                    }
                }
            }
            promedio = suma / 45;
            Console.WriteLine("el promedo de edad es: " + promedio);
        }

        static void Main(string[] args)
        {
            Act2 A2 = new Act2();
            A2.CrearAsientos();
            A2.VentaEntradas();
            A2.imprimirMapa();
            A2.calcularMenores();
            A2.promedioEdades();
            Console.ReadKey();
        }
    }
}
