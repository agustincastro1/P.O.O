using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
    2. Catálogo de Películas (Encapsulación, Validación y Composición)
Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del catálogo. 
    */
    class Pelicula
    {
        private string Titulo;
        private int DuracionMinutos;
        private float Calificacion;

        public string titulo
        {
            set
            {
                Titulo = value;
            }
            get
            {
                return Titulo;
            }
        }
        public int duracionMinutos
        {
            set
            {
                DuracionMinutos = value;
            }
            get
            {
                return DuracionMinutos;
            }
        }
        public float calificacion
        {
            set
            {
                Calificacion = value;
            }
            get
            {
                return Calificacion;
            }
        }

        public Pelicula()
        {
            string linea;
            Console.WriteLine("ingrese el titulo: ");
            titulo = Console.ReadLine();

            Console.WriteLine("Ingrese la duracion en minutos (> a 0):");
            for (int i = 0; i < 1; i++)
            {
                linea = Console.ReadLine();
                if (int.Parse(linea) > 0)
                {
                    duracionMinutos = int.Parse(linea);
                }
                else
                {
                    Console.WriteLine("ingrese una duracion > a 0");
                    i--;
                }
            }

            Console.WriteLine("Ingrese la calificacion en estrellas (1 a 5): ");
            linea = Console.ReadLine();
                if (int.Parse(linea) > 1 && int.Parse(linea) <= 5)
                {
                    calificacion = int.Parse(linea);
                }
                else
                {
                    calificacion = 1;
                }
        }
    }
    
    class Catalogo
    {
        public Pelicula[] peliculas;
        public Catalogo()
        {
            peliculas = new Pelicula[3];
            for (int i = 0; i < 3; i++)
            {
                peliculas[i] = new Pelicula();
            }

        }
        public void MostrarPeliculas()
        {

            for (int i = 0; i < peliculas.Length; i++)
            {
                for (int j = 0; j < 3 - i - 1; j++)
                {
                    if (peliculas[j].duracionMinutos < peliculas[j + 1].duracionMinutos)
                    {
                        Pelicula aux = peliculas[j];
                        peliculas[j] = peliculas[j + 1];
                        peliculas[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Catalogo de peliculas por su Duracion: ");
            for (int i = 0; i < peliculas.Length; i++)
            {
                Console.WriteLine("Titulo: " + peliculas[i].titulo + " Duracion: " + peliculas[i].duracionMinutos + " Calificacion: " + peliculas[i].calificacion);
            }
            Console.WriteLine("Pelicula con menor duacion: " + peliculas[2].titulo);
            for (int i = 0; i < peliculas.Length; i++)
            {
                for (int j = 0; j < 3 - i - 1; j++)
                {
                    if (peliculas[j].calificacion < peliculas[j + 1].calificacion)
                    {
                        Pelicula aux = peliculas[j];
                        peliculas[j] = peliculas[j + 1];
                        peliculas[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("La pelicula con mejor calificacion es: " + peliculas[0].titulo);

        }
        static void Main(string[] args)
        {
            Catalogo c = new Catalogo();
            c.MostrarPeliculas();
            Console.ReadKey();
        }
    }
}
