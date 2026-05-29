using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
        4. Inventario de Sucursales 
            Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. 
            El constructor de la clase debe cargar estos atributos por teclado.
            Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. 
            El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
            Implementar en la clase Sucursal los siguientes métodos:
            Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
            Un método que busque y muestre el nombre del artículo más caro del local.
            Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente 
            (aquellos cuyo stock sea menor o igual a 5 unidades).
    */
    class Articulo
    {
        private string NombreArticulo;
        private float Precio;
        private int StockActual;

        public Articulo()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del articulo:");
            linea = Console.ReadLine();
            NombreArticulo = linea;

            Console.WriteLine("Ingrese el precio del articulo:");
            linea = Console.ReadLine();
            Precio = float.Parse(linea);

            Console.WriteLine("Ingrese el Stock del articulo:");
            linea = Console.ReadLine();
            StockActual = int.Parse(linea);
        }

        public string retornarNombre()
        {
            return NombreArticulo;
        }

        public float retornarPrecio()
        {
            return Precio;
        }

        public int retornarStockActual()
        {
            return StockActual;
        }
    }

    class Sucursal
    {
        private Articulo[] Articulos;
        public Sucursal()
        {
            Articulos = new Articulo[3];
            for (int i = 0; i < 3; i++)
            {
                Articulos[i] = new Articulo();
            }
        }
        public void imprimirListaArticulos()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nombre del Articulo: " + Articulos[i].retornarNombre() + " Stock: " + Articulos[i].retornarStockActual() + " Precio total: " + Articulos[i].retornarPrecio() * Articulos[i].retornarStockActual());
            }
        }

        public void articuloCaro()
        {
            float precioArtCaro = Articulos[0].retornarPrecio();
            string nombreArtCaro = Articulos[0].retornarNombre();
                if (precioArtCaro < Articulos[1].retornarPrecio())
                {
                    precioArtCaro = Articulos[1].retornarPrecio();
                    nombreArtCaro = Articulos[1].retornarNombre();
                }
                if (precioArtCaro < Articulos[2].retornarPrecio())
                {
                    precioArtCaro = Articulos[2].retornarPrecio();
                    nombreArtCaro = Articulos[2].retornarNombre();
                }
        }

        public void reStock()
        {
            for (int i = 0; i < 3; i++)
            {
                if (Articulos[i].retornarStockActual() <= 5)
                {
                    Console.WriteLine("El articulo " + Articulos[i].retornarNombre() + " necesita reposicion");
                }
            }
        }
        static void Main(string[] args)
        {
            Sucursal s = new Sucursal();
            s.imprimirListaArticulos();
            s.articuloCaro();
            s.reStock();
            Console.ReadKey();
        }
    }
}
