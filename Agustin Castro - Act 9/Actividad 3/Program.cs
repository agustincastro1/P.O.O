using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    class Vectores3 
    {
        /*
        3.  Se registran los nombres de 5 atletas y sus tiempos (en segundos) en una
            carrera de 100 metros. El programa debe cargar los datos en dos vectores
            paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
            atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
            promedio
        */
        private string[] atletas;
        private int[] tiempos;
        private int promedio;
        private string[] superaronPromedio;
        private int contSuperaron = 0;
        private string mejorTiempo;
        private string peorTiempo;

        public void cargar()
        {
            atletas = new string[5];
            tiempos = new int[5];
            for (int i = 0; i < atletas.Length; i++) 
            {
                string linea;
                Console.WriteLine("ingrese el nombre del atleta:");
                linea = Console.ReadLine();
                atletas[i] = linea;

                Console.WriteLine("ingrese el tiempo del atleta:");
                linea = Console.ReadLine();
                tiempos[i] = int.Parse(linea);
            }
        }

        public void calcular()
        {
            for (int i = 0; i < tiempos.Length; i++)
            {
                for (int j = 0; j < tiempos.Length - i - 1; j++)
                {
                    if (i != 4)
                    {
                        if (tiempos[j] > tiempos[j + 1])
                        {
                            int aux;
                            string auxAtle;
                            aux = tiempos[j];
                            auxAtle = atletas[j];
                            atletas[j] = atletas[j + 1];
                            tiempos[j] = tiempos[j + 1];
                            atletas[j + 1] = auxAtle;
                            tiempos[j + 1] = aux;
                        }
                    }
                }
            }
            promedio = tiempos.Sum() / tiempos.Length;
            mejorTiempo = atletas[0];
            peorTiempo = atletas[4];
            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] < promedio)
                {
                    contSuperaron++;
                }
            }
        }

        public void mostrar()
        {
            Console.WriteLine("promedio de los tiempos: " + promedio);
            Console.WriteLine("atleta con peor tiempo: " + peorTiempo);
            Console.WriteLine("atleta con mejor tiempo: " + mejorTiempo);
            Console.WriteLine("atletas con un tiempo mejor al promedio:");
            superaronPromedio = new string[contSuperaron];
            for (int i = 0; i < contSuperaron; i++)
            {
                superaronPromedio[i] = atletas[i];
                Console.WriteLine(superaronPromedio[i] + " con un tiempo de: " + tiempos[i]);
            }
        }
        static void Main(string[] args)
        {
            Vectores3 v3 = new Vectores3();
            v3.cargar();
            v3.calcular();
            v3.mostrar();
            Console.ReadKey();
        }
    }
}
