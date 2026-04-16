using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Actividad_3
{
    /*3. Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
    un videojuego. El programa debe:
    - Mostrar la puntuación más alta y la más baja.
    - Calcular el promedio de puntuación.
    - Contar cuántas veces superó los 500 puntos.*/
    class Vectores3
    {
        private int[] Vector;

        public void cargar()
        {
            Vector = new int[6];
            for (int i = 0; i<6; i++) 
            {
                Console.WriteLine("ingrese la puntuacion de su partida: ");
                string linea;
                linea = Console.ReadLine();
                Vector[i] = int.Parse(linea);
            }
        }
        int mas500 = 0;
        int promedio;
        
        public void calcular()
        {
            
            int suma = 0;
            int aux = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int t = 0; t < 6 - i - 1; t++)
                {
                    if (Vector[t] > Vector[t+1])
                    {
                        aux = Vector[t];
                        Vector[t] = Vector[t+1];
                        Vector[t+1] = aux;
                    }
                }
                if (Vector[i] >500)
                {
                    mas500++;
                }
                suma = suma + Vector[i];
            }
            promedio = suma / 6;
        }

        public void mostrar()
        {
            Console.WriteLine("la puntuacion mas baja es: " + Vector[0]);
            Console.WriteLine("la puntuacion mas alta es: " + Vector[5]);
            Console.WriteLine("la cantidad de veces que se superaron los 500 puntos es: " + mas500);
            Console.WriteLine("el podmedio de puntos es: " + promedio);
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
