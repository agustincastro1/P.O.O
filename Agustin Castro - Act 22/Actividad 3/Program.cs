using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
Plantear una clase Entrenamiento con atributos: deportista y duración (en minutos).
 Incluir dos métodos RegistrarDuracion (sobrecarga de métodos):
1. Uno que reciba horas y minutos y los convierta a minutos.
2. Otro que reciba directamente los minutos.
 Crear una lista con 5 entrenamientos y mostrar el entrenamiento más largo y el
más corto. 
    */
    internal class Entrenamiento
    {
        private string deportista;
        private int duracion;
        public string Deportista
        {
            set
            {
                deportista = value;
            }
            get
            {
                return deportista;
            }
        }
        public int Duracion
        {
            set
            {
                duracion = value;
            }
            get
            {
                return duracion;
            }
        }
        
        public void RegistrarDuracion(int minutos)
        {
            Console.WriteLine("Ingrese el nombre del deportista ");
            deportista = Console.ReadLine();
            duracion = minutos; 
        }
        public void RegistrarDuracion(int horas, int minutos)
        {
            Console.WriteLine("Ingrese el nombre del deportista ");
            deportista = Console.ReadLine();
            duracion = minutos + horas * 60;
        }
        static void Main(string[] args)
        {
            List<Entrenamiento> listaDuracion = new List<Entrenamiento>();
            for (int i = 0; i < 5; i++)
            {
                Entrenamiento entr = new Entrenamiento();
                listaDuracion.Add(entr);
            }
            for (int i = 0; i < 5; i++) {
                if (i >= 3) {

                    int minutos;
                    Console.WriteLine("Ingrese los minutos que va a durar el entrenamiento");
                    minutos = int.Parse(Console.ReadLine());
                    listaDuracion[i].RegistrarDuracion(minutos);
                }
                else
                {
                    int minutos;
                    int horas;
                    Console.WriteLine("Ingrese las horas y minutos que va a durar el entrenamiento");
                    Console.WriteLine("Horas");
                    horas = int.Parse(Console.ReadLine());
                    Console.WriteLine("Minutos");
                    minutos = int.Parse(Console.ReadLine());

                    listaDuracion[i].RegistrarDuracion(horas,minutos);
                }
            }

            Entrenamiento aux;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5 - 1 -i; j++)
                {
                    if (listaDuracion[j].Duracion > listaDuracion[j+1].Duracion)
                    {
                        aux = listaDuracion[j+1];
                        listaDuracion[j + 1] = listaDuracion[j];
                        listaDuracion[j] = aux; 
                    }
                }
            }
            Console.WriteLine($"El deportista que mas timpo entreno fue {listaDuracion[4].Deportista} con {listaDuracion[4].duracion} en minutos");
            Console.WriteLine($"El deportista que menos tiempo entreno fue {listaDuracion[0].Deportista} con {listaDuracion[0].duracion} en minutos");
            Console.ReadKey();
        }
    }
}
