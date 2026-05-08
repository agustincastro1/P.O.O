using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
     Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una cantidad diferente de paquetes por día dependiendo de su demanda.
        ● Definir un vector de tipo string para los nombres de las 3 sucursales.
        ● Definir una matriz irregular donde cada fila sea una sucursal y cada columna represente el peso (en kg) de cada paquete enviado.
            ● Métodos:
                1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos paquetes se enviaron hoy para definir el tamaño de su fila.
                2. Cargar el peso de cada paquete.
                3. Imprimir el peso de todos los paquetes organizados por sucursal.
                4. Calcular e informar el peso total despachado por cada sucursal.
                5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal pertenece.
     */
    class Vectores
    {
        private string[] sucursales;
        private int[][] peso;
        private int[] pesosTotales;
        public void cargarTamaños()
        {
            string linea;
            sucursales = new string[3];
            peso = new int[3][];
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.WriteLine("ingrese el nombre de una sucursal: ");
                linea = Console.ReadLine();
                sucursales[i] = linea;
            }
            for (int i = 0;i < sucursales.Length; i++)
            {
                Console.WriteLine("¿Cuantos paquetes envió " + sucursales[i] + "?");
                linea = Console.ReadLine();
                peso[i] = new int[int.Parse(linea)];
            }
        }
        public void cargarPesos()
        {
            string linea;
            for (int i = 0; i < peso.GetLength(0); i++)
            {
                for (int j = 0; j < peso[i].GetLength(0); j++) 
                {
                    Console.WriteLine("ingrese el peso de los paquetes de " + sucursales[i] +  " en KG");
                    linea = Console.ReadLine();
                    peso[i][j] = int.Parse(linea);
                }
            }
        }

        public void mostrarPesos()
        {
            Console.WriteLine("Todos los pesos de los paquetes por sucursal");
            for (int i = 0; i < peso.GetLength(0); i++)
            {
                Console.Write(sucursales[i] + " ");
                for (int j = 0; j < peso[i].GetLength(0); j++)
                {
                    Console.Write(peso[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void pesoTotal()
        {
            int suma = 0;

            pesosTotales = new int[3];
            Console.WriteLine("total de los pesos por sucursal");
            for (int i = 0; i < peso.GetLength(0); i++)
            {
                for (int j = 0; j < peso[i].Length; j++)
                {
                    suma = suma + peso[i][j];
                }
                pesosTotales[i] = suma;
                suma = 0;
            }
            for (int i = 0;i < pesosTotales.Length; i++)
            {
                Console.WriteLine("la sucursal: " + sucursales[i] + " envió " + pesosTotales[i] + "KG´s");
            }
        }

        public void masPesado()
        {
            int masPesado = peso[0][0];
            string masPesadoSuc = sucursales[0];
            for (int i = 0; i < sucursales.Length; i++)
            {
                for (int j = 0; j < peso[i].Length - 1; j++)
                {
                    if (peso[i][j] < peso[i][j + 1])
                    {
                        masPesado = peso[i][j + 1];
                        masPesadoSuc = sucursales[i];
                    }
                }
            }
            Console.WriteLine("el paquete mas pesado pesa: " +  masPesado + " y pertenece a: " + masPesadoSuc);
        }
        static void Main(string[] args)
        {
            Vectores v1 = new Vectores();
            v1.cargarTamaños();
            v1.cargarPesos();
            v1.mostrarPesos();
            v1.pesoTotal();
            v1.masPesado();
            Console.ReadKey();
        }
    }
}
