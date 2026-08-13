using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Actividad_6.Program;

namespace Actividad_6
{
    /*
    Una biblioteca pública gestiona de forma digital su catálogo de obras literarias
para organizar la consulta de ejemplares por parte de los lectores.
 Crear la clase Libro que contenga como atributos privados: titulo
(string) y anioPublicacion (int). Definir sus propiedades de solo lectura y
un constructor que reciba tit y anio.
 Crear la clase BibliotecaCentral que administre una lista de objetos
List.
 Métodos en BibliotecaCentral:
1. CargarCatalogo(): Solicitar por teclado títulos y años de
publicación para agregar libros a la lista mediante .Add(). La carga
finaliza cuando el usuario ingresa la palabra &quot;FIN&quot; como título.
2. ListarCatalogo(): Mostrar en pantalla todos los libros del catálogo
junto a la cantidad total de obras registradas mediante la propiedad
.Count.
3. FiltrarPorAnio(): Solicitar al usuario un año determinado e
imprimir en consola únicamente aquellos libros cuyo año de
publicación sea menor a dicho valor.
4. RemoverLibro(): Pedir al usuario el título de un libro y, utilizando
los métodos de búsqueda y remoción de listas, eliminarlo de la
colección si se encuentra presente.
    */
    internal class Program
    {
        public class Libro
        {
            // Atributos privados
            private string titulo;
            private int añoPublicacion;

            public string Titulo
            {
                get { return titulo; }
            }

            public int AñoPublicacion
            {
                get { return añoPublicacion; }
            }

            // Constructor
            public Libro(string tit, int anio)
            {
                this.titulo = tit;
                this.añoPublicacion = anio;
            }

            // Método auxiliar para mostrar los datos del libro
            public void MostrarInformacion()
            {
                Console.WriteLine($"Título: {Titulo} | Año de Publicación: {AñoPublicacion}");
            }
        }
    }
    public class BibliotecaCentral
    {
        // Lista de libros que administra la biblioteca
        private List<Libro> catalogo;

        public BibliotecaCentral()
        {
            catalogo = new List<Libro>();
        }

        // 1. CargarCatalogo(): Carga iterativa que finaliza al ingresar "FIN"
        public void CargarCatalogo()
        {
            Console.WriteLine("Cargar catalogo");
            Console.WriteLine("(Ingrese 'FIN' en el título para terminar el alta de libros)");

            while (true)
            {
                string linea;
                Console.Write("Ingrese el título del libro: ");
                string titulo = Console.ReadLine();

                if (titulo == "fin" || titulo == "Fin" || titulo == "FIN")
                {
                    Console.WriteLine("Carga de catálogo finalizada.");
                    break;
                }

                Console.Write("Ingrese el año de publicación: ");
                linea = Console.ReadLine();
                int año = int.Parse(linea);

                if (año > 0)
                {
                    Libro nuevoLibro = new Libro(titulo, año);
                    catalogo.Add(nuevoLibro);
                    Console.WriteLine("Libro registrado con éxito.");
                }
                else
                {
                    Console.WriteLine("Año no válido. No se registró el libro.");
                }
            }
        }

        public void ListarCatalogo()
        {
            Console.WriteLine("Catalogo completo");

            if (catalogo.Count > 0)
            {
                foreach (Libro libro in catalogo)
                {
                    libro.MostrarInformacion();
                }

                Console.WriteLine("------------------------------------------------");
                Console.WriteLine($"Total de obras registradas: {catalogo.Count}");
            }
            else
            {
                Console.WriteLine("El catálogo está vacío actualmente.");
            }
        }

        public void FiltrarPorAño()
        {
            Console.WriteLine("Filtrar libros por año");
            Console.Write("Ingrese un año para mostrar los libros que salieron antes del año ingresado: ");
            string linea = Console.ReadLine();
            int añoLimite = int.Parse(linea);

            Console.WriteLine($"Obras publicadas antes del año {añoLimite}:");
            bool encontrado = false;

            foreach (Libro libro in catalogo)
            {
                if (libro.AñoPublicacion < añoLimite)
                {
                    libro.MostrarInformacion();
                    encontrado = true;
                }
            }

            if (encontrado == false)
            {
                Console.WriteLine($"No hay publicaciones anteriores al año {añoLimite}.");
            }
        }

        public void RemoverLibro()
        {
            Console.WriteLine("Remover Libro");
            Console.Write("Ingrese el título del libro que desea eliminar: ");
            string linea = Console.ReadLine();

            bool encontro = false;

            for (int i = 0; i < catalogo.Count; i++)
            {
                if (catalogo[i].Titulo == linea)
                {
                    Console.WriteLine($"El libro {catalogo[i].Titulo} fue removido del catálogo.");
                    catalogo.Remove(catalogo[i]);
                    encontro = true;
                    break;
                }
            }

            if (encontro == false)
            {
                Console.WriteLine($"No se encontró ninguna obra con el título {linea}.");
            }
        }
        static void Main(string[] args)
        {
            BibliotecaCentral biblioteca = new BibliotecaCentral();

            while (true)
            {
                string linea;
                int eleccion;
                Console.WriteLine("Sistema de biblioteca central");
                Console.WriteLine("1. Cargar catálogo");
                Console.WriteLine("2. Listar catálogo completo");
                Console.WriteLine("3. Filtrar obras por año");
                Console.WriteLine("4. Remover un libro");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                linea = Console.ReadLine();
                eleccion = int.Parse(linea);

                if (eleccion == 1)
                {
                    Console.Clear();
                    biblioteca.CargarCatalogo();
                }
                if (eleccion == 2)
                {
                    Console.Clear();
                    biblioteca.ListarCatalogo();
                }
                if (eleccion == 3)
                {
                    Console.Clear();
                    biblioteca.FiltrarPorAño();
                }
                if (eleccion == 4)
                {
                    Console.Clear();
                    biblioteca.RemoverLibro();
                }
                if (eleccion == 5)
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}