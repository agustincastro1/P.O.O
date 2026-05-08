using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*1. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como
             dato las temperaturas medias mensuales de dichos paises.
             Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
             mensuales.
             Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.

             a. Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
             b. Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.
             c. Calcular la temperatura media trimestral de cada país.
             d. Imprimir los nombres de los paises y las temperaturas medias trimestrales.
             e. Imprimir el nombre del país con la temperatura media trimestral mayor.
    */

    class MatrizDent1
    {
        private string[] paises;
        private int[,] temperaturas;
        private int[] tempMedia;
        
        public void cargar()
        {
            Console.WriteLine("ingrese la cantidad de paises: ");
            string linea = Console.ReadLine();
            paises = new string[int.Parse(linea)];
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine("ingrese el nombre del pais: ");
                paises[i] = Console.ReadLine();
                if (i == 0)
                {
                    temperaturas = new int[paises.Length, 3];
                }
                    for (int f = 0; f < temperaturas.GetLength(1); f++)
                    {
                    Console.WriteLine("ingrese la temperatura del pais");
                    linea = Console.ReadLine();
                    temperaturas[i,f] = int.Parse(linea);
                    }
            }
        }

        public void imprimirTemp()
        {
            Console.WriteLine("Paises y sus temperaturas: ");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write(paises[i]);
                for (int f = 0; f < temperaturas.GetLength(1); f++)
                {
                    Console.Write(" " + temperaturas[i, f]);
                }
                Console.WriteLine();
            }
        }

        public void calcTempMedia()
        {
            tempMedia = new int[paises.Length];
            for (int i = 0; i < paises.Length; i++)
            {
                int suma = 0;
                int promedio = 0;
                for (int f = 0; f < temperaturas.GetLength(1); f++)
                {
                    suma = suma + temperaturas[i, f];
                }
                promedio = suma / temperaturas.GetLength(1);
                tempMedia[i] = promedio;
            }
        }

        public void imprimirTempMedias()
        {
            int tempMediaMay = tempMedia[0];
            string paisMayMedia = paises[0];
            Console.WriteLine("Paises y sus temperaturas medias: ");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write(paises[i] + " Temperatura media:  " + tempMedia[i]);
                Console.WriteLine();
            }
            for(int i = 0; i < tempMedia.Length - 1; i++)
            {
                if (tempMedia[i] < tempMedia[i + 1])
                {
                    tempMediaMay = tempMedia[i + 1];
                    paisMayMedia = paises[i + 1];
                }
            }
            Console.WriteLine("Pais con mayor media de temperatura: ");
            Console.Write(paisMayMedia + " " + tempMediaMay);
        }
        static void Main(string[] args)
        {
            MatrizDent1 MD1 = new MatrizDent1();
            MD1.cargar();
            MD1.imprimirTemp();
            MD1.calcTempMedia();
            MD1.imprimirTempMedias();
            Console.ReadKey();
        }
    }
}
