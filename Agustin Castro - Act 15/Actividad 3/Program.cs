using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
     Geolocalización de Reservas Naturales
Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
especies protegidas en cuadrículas de territorio.
● Confeccionar la clase ReservaNatural que tenga como atributos privados el
NombreReserva y una matriz llamada avistamientos de 3x3 (que representa un
mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
cantidad de animales avistados en cada sector). El constructor de la clase debe
cargar por teclado el nombre y rellenar el mapa de avistamientos.
● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
objetos de la clase ReservaNatural.
La clase CentroEcologico debe implementar los siguientes métodos:
1. Un constructor que solicite la carga secuencial de las 3 reservas.
2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
registró en toda su superficie (la suma de toda su matriz rectangular).
3. Un método que determine e informe cuál fue la coordenada o sector específico ([fila,
columna]) que registró la mayor concentración de avistamientos de toda la red de
reservas, indicando a qué reserva pertenece.
     */
    class ReservaNatural
    {
        private string nombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            avistamientos = new int[3, 3];

            Console.WriteLine("Ingrese el nombre de la reserva:");
            nombreReserva = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingrese los avistamientos del sector [" + i + "," + j + "]:");
                    avistamientos[i, j] = int.Parse(Console.ReadLine());
                }
            }
        }

        public string retornarNombre()
        {
            return nombreReserva;
        }

        public int[,] retornarAvistamientos()
        {
            return avistamientos;
        }
    }

    class CentroEcologico
    {
        private ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];

            for (int i = 0; i < 3; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }

        public void enlistarReservas()
        {
            for (int i = 0; i < reservas.Length; i++)
            {
                int suma = 0;
                int[,] matriz = reservas[i].retornarAvistamientos();

                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        suma = suma + matriz[f, c];
                    }
                }

                Console.WriteLine("Reserva: " + reservas[i].retornarNombre());
                Console.WriteLine("Total de avistamientos: " + suma);
            }
        }

        public void mayorConcentracion()
        {
            int[,] primerAvistamiento = reservas[0].retornarAvistamientos();

            int maximo = primerAvistamiento[0, 0];
            string nombreReserva = reservas[0].retornarNombre();
            int fila = 0;
            int columna = 0;

            for (int i = 0; i < reservas.Length; i++)
            {
                int[,] Avistamientos = reservas[i].retornarAvistamientos();

                for (int f = 0; f < 3; f++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (Avistamientos[f, c] > maximo)
                        {
                            maximo = Avistamientos[f, c];
                            nombreReserva = reservas[i].retornarNombre();
                            fila = f;
                            columna = c;
                        }
                    }
                }
            }

            Console.WriteLine("La mayor concentración de avistamientos se registró en la reserva: " + nombreReserva);
            Console.WriteLine("Coordenada: [" + fila + "," + columna + "]");
            Console.WriteLine("Cantidad de avistamientos: " + maximo);
        }

        static void Main(string[] args)
        {
            CentroEcologico centro = new CentroEcologico();
            centro.enlistarReservas();
            centro.mayorConcentracion();
            Console.ReadKey();
        }
    }
}