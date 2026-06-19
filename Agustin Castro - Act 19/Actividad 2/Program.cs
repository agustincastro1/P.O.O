using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
    2. Crear una clase parcial Libro.
En el primer archivo, declarar las propiedades Título, Autor y Páginas. Validar que la
cantidad de páginas sea mayor a 10. Valores cargados desde consola
En el segundo archivo, agregar un método Resumen() que muestre el título, autor y
si el libro es corto (menos de 100 páginas) o largo.
Desde la clase principal, cargar 2 libros y mostrar cuál es el más extenso. 
    */
    class Program
    {
        public Libro[] Libros;
        public Program()
        {
            Libros = new Libro[2];
            for (int i = 0; i < 2; i++)
            {
                Libros[i] = new Libro();
            }
        }
        public void Resumen()
        {
            for (int i = 0; i < 2; i++)
            {
            Console.WriteLine("Resumen del libro:");
            Console.WriteLine("Titulo: " + Libros[i].titulo + " Autor: " + Libros[i].autor + " Paginas: " + Libros[i].paginas);
                if (Libros[i].paginas > 100)
                {
                    Console.WriteLine(Libros[i].titulo + " Es un libro largo");
                }
                else
                {
                    Console.WriteLine(Libros[i].titulo + " Es un libro corto");
                }
            }
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.Resumen();
        }
    }
}
