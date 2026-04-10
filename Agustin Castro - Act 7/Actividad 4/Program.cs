using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
    4. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
    ordenado de menor a mayor y de mayor a menor.*/
    class Vectores4
    {
        private int[] vector;

        public void cargar()
        {
            vector = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ingresa un numero: ");
                string linea;
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }

        public void calcularMostrar()
        {
            int contMayMen = 0;
            int contMenMay = 0;
            for (int i = 0; i < 9; i++)
            {
                if (vector[i] > vector[i + 1])
                {
                    contMayMen++;
                }
                if (vector[i+1] > vector[i])
                {
                    contMenMay++;
                }

            }
            if(contMayMen == vector.Length - 1)
                {
                Console.WriteLine("Está ordenado de mayor a menor");
                
                }
            if (contMenMay == vector.Length - 1)
            {
                Console.WriteLine("Está ordenado de menor a mayor");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(vector[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Vectores4 v4 = new Vectores4();
            v4.cargar();
            v4.calcularMostrar();
            Console.ReadKey();
        }
    }
}
