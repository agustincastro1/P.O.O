using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
     3. Competencia de Atletismo
        Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera).
        Definir un constructor para ingresar ambos datos.
        Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
        Definir los siguientes métodos en la clase Carrera:
        Un constructor que cargue los datos de los 3 atletas de la carrera.
        Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
        Un método que calcule e imprima el tiempo promedio de la carrera.
        Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
        Un método que muestre a los atletas que superaron el promedio.

    */
    class Atleta
    {
        private string Nombre;
        private float TiempoSegundos;
        public Atleta()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del atleta: ");
            linea = Console.ReadLine();
            Nombre = linea;

            Console.WriteLine("Ingrese el tiempo del atleta: ");
            linea = Console.ReadLine();
            TiempoSegundos = float.Parse(linea);
        }

        public string retornarNombre()
        {
            return Nombre;
        }

        public float retornarTiempo()
        {
            return TiempoSegundos;
        }
    }

    class Carrera
    {
        private Atleta[] Atletas;
        private float promedio = 0;

        public Carrera()
        {
            Atletas = new Atleta[3];
            for (int i = 0; i < 3; i++)
            {
                Atletas[i] = new Atleta();
            }
        }

        public void imprimirAtletas()
        {
            Console.WriteLine("Atletas y sus tiempos:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nombre: " + Atletas[i].retornarNombre() + " Tiempo: " + Atletas[i].retornarTiempo());
            }
        }

        public void promedioCarrera()
        {
            for (int i = 0; i < 3; i++)
            {
                promedio = (promedio + Atletas[i].retornarTiempo())/3;
            }
            Console.WriteLine("El promedio de tiempo de la carrera es: " + promedio);
        }

        public void ganadorCarrera()
        {
            float menorTiempo = Atletas[0].retornarTiempo();
            string ganador = Atletas[0].retornarNombre();
            if (menorTiempo > Atletas[1].retornarTiempo())
            {
                menorTiempo = Atletas[1].retornarTiempo();
                ganador = Atletas[1].retornarNombre();
            }
            if (menorTiempo > Atletas[2].retornarTiempo())
            {
                menorTiempo = Atletas[2].retornarTiempo();
                ganador = Atletas[2].retornarNombre();
            }
            Console.WriteLine("El ganador es: " + ganador + " con un tiempo de: " + menorTiempo + "s");
        }

        public void superaronPromedio()
        {
            for (int i = 0; i < 3; i++)
            {
                if (promedio > Atletas[i].retornarTiempo())
                {
                    Console.WriteLine("El atleta: " + Atletas[i].retornarNombre() + " superó el promedio");
                }
            }
        }

        static void Main(string[] args)
        {
            Carrera c = new Carrera();
            c.imprimirAtletas();
            c.promedioCarrera();
            c.ganadorCarrera();
            c.superaronPromedio();
            Console.ReadKey();
        }
    }
}
