using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*2. Una empresa registra los nombres de sus 5 vendedores y el total de ventas
         realizadas por cada uno en un mes. Cargar los nombres y ventas en dos
         vectores paralelos, ordenar los datos de mayor a menor según las ventas,
         imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
         el que menos vendió de los 5 empleados.*/
    class Vectores2
    {
        private string[] vendedores;
        private string[] mismasVentas;
        private int[] ventas;
        int menorVenta;

        public void cargar()
        {
            vendedores = new string[5];
            ventas = new int[5];
            for(int i = 0; i <vendedores.Length;i++)
            { 
                Console.WriteLine("ingrese el nombre del empleado:");
                string linea;
                linea = Console.ReadLine();
                vendedores[i] = linea;

                Console.WriteLine("ingrese el total de ventas del empleado:");
                linea = Console.ReadLine();
                ventas[i] = int.Parse(linea);
            }
        }

        public void ordenar()
        {
            for (int i = 0; i < vendedores.Length; i++)
            {
                for (int j = 0; j < vendedores.Length - i - 1; j++)
                {
                    if (i != 4)
                    {
                        if (ventas[j] > ventas[j + 1])
                        {
                            int aux;
                            string auxVend;
                            aux = ventas[j];
                            auxVend = vendedores[j];
                            vendedores[j] = vendedores[j + 1];
                            ventas[j] = ventas[j + 1];
                            vendedores[j + 1] = auxVend;
                            ventas[j + 1] = aux;
                        }
                    }
                }
            }
            menorVenta = ventas[0];
            int x = 0;
            for (int i = 0; i < vendedores.Length; i++)
            {
                if (ventas[i] == menorVenta)
                {
                    mismasVentas[x] = vendedores[i];
                    x++;
                }
            }
        }

        public void mostrar()
        {
            for (int i = 0; i < mismasVentas.Length; i++)
            {
                Console.WriteLine("Vendedores con mas ventas: " + mismasVentas[i] + " Ventas: " + menorVenta);
            }
        }
        static void Main(string[] args)
        {
            Vectores2 v2 = new Vectores2();
            v2.cargar();
            v2.ordenar();
            v2.mostrar();
            Console.ReadKey();
        }
    }
}
