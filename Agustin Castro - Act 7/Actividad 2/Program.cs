using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*2. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
    tercer vector del mismo tamaño. Sumar componente a componente.*/
    class Vectores2
    {
        private int[] vector1;
        private int[] vector2;
        private int[] vector3;

        public void cargar()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            vector3 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                string linea;
                Console.WriteLine("ingrese un valor al primer vector: ");
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);

                Console.WriteLine("ingrese un valor al segundo vector: ");
                linea = Console.ReadLine();
                vector2[i] = int.Parse(linea);
            }
        }

        public void calcular()
        {
            for (int i = 0; i < 4 ; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }

        public void mostrar()
        {
            Console.WriteLine("valor de la suma del primer vector y el segundo: ");
            Console.WriteLine(vector3[0] + "-" + vector3[1] +  "-" +  vector3[2] + "-" + vector3[3]);
        }
        static void Main(string[] args)
        {
            Vectores2 v2 = new Vectores2();
            v2.cargar();
            v2.calcular();
            v2.mostrar();
            Console.ReadKey();
        }
    }
}
