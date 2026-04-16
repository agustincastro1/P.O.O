using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*1. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    El valor acumulado de todos los elementos del vector.
    El valor acumulado de los elementos del vector que sean mayores a 36.
    Cantidad de valores mayores a 50.*/
    class Vectores
    {

        private int[] vector;
        private int valorAcumulado = 0;
        private int mayores36 = 0;
        private int mayores50 = 0;

        public void cargar()
        {
            vector = new int[8];
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine("ingrese un numero: ");
                string linea;
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }

        public void calcular()
        {
            for (int i = 0; i < 8; i++)
            {
                if (vector[i]>36)
                {
                    mayores36++;
                }
                if (vector[i] > 50)
                {
                    mayores50++;
                }
                valorAcumulado = valorAcumulado + vector[i];
            }
        }
        public void mostrar()
        {
            Console.WriteLine("cantidad de valores mayores a 36 = " + mayores36);
            Console.WriteLine("cantidad de valores mayores a 50 = " + mayores50);
            Console.WriteLine("valor acumulado de todos los valores del vector = " + valorAcumulado);
        }
        static void Main(string[] args)
        {
            Vectores v = new Vectores();
            v.cargar();
            v.calcular();
            v.mostrar();
            Console.ReadKey();
        }
    }
}
