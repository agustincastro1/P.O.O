using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    partial class Libro
    {
        private string Titulo;
        private string Autor;
        private int Paginas;

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
        public string autor
        {
            set
            {
                Autor = value;
            }
            get
            {
                return Autor;
            }
        }
        public int paginas
        {
            set
            {
                Paginas = value;
            }
            get
            {
                return Paginas;
            }
        }
        public Libro()
        {
            string linea;
            Console.WriteLine("Ingrese el titulo del libro: ");
            Titulo = Console.ReadLine();

            Console.WriteLine("Ingrese el nombre del autor:");
            Autor = Console.ReadLine();

            for (int i = 0; i < 1; i++)
            {
            Console.WriteLine("Ingrese la cantidad de paginas:");
            linea = Console.ReadLine();
                if (int.Parse(linea) > 10)
                {
                    Paginas = int.Parse(linea);
                }
                else
                {
                    Console.WriteLine("Ingrese una cantidad de paginas mayor a 10");
                    i--;
                }
            }
        }
    }
}
