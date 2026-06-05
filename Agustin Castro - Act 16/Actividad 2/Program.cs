using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
    Plantear una clase Producto y otra clase Inventario.
    La clase Producto debe tener como atributos privados el nombre, precio y stock.
    Definir propiedades para acceder a estos atributos, asegurando que el stock no pueda ser negativo y el precio sea mayor a cero.
    La clase Inventario debe contener 3 objetos de la clase Producto. 
    Definir un método para mostrar todos los productos ordenados de menor a mayor en base al precio
    además, mostrar el producto más caro y más barato del inventario.
     */
    internal class Producto
    {
        private string nombre;
        private float precio;
        private int stock;
        string linea;

        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public float Precio
        {
            set
            {

                precio = value;
            }
            get
            {
                return precio;
            }
        }

        public int Stock
        {
            set
            {
                stock = value;
            }
            get
            {
                return stock;
            }
        }
        public Producto()
        {
            Console.WriteLine("ingrese el nombre del producto");
            linea = Console.ReadLine();
            nombre = linea;

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("ingrese el precio");
                linea = Console.ReadLine();
                if (float.Parse(linea) > 0)
                {
                    precio = float.Parse(linea);
                }
                else
                {
                    Console.WriteLine("ingrese datos validos, no puede haber precios iguales o menores a 0");
                    i--;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("ingrese el stock");
                linea = Console.ReadLine();
                if (int.Parse(linea) >= 0)
                {
                stock = int.Parse(linea);
                }
                else
                {
                    Console.WriteLine("ingrese datos validos, no puede haber stock menor a 0");
                    i--;
                }
            }
        }
    }
    class inventario
    {
        private Producto[] producto;
        private string caro;
        private string barato;

        public inventario()
        {
            producto = new Producto[3];

            for (int i = 0; i < producto.Length; i++)
            {
                producto[i] = new Producto();
            }
        }
        public void mostrarMenorAMayor()
        {
            for (int i= 0; i < 3; i ++)
            { 
                for (int j = 0; j < 3 - i - 1; j++)
                {
                    if (producto[j].Precio > producto[j + 1].Precio)
                    {
                        Producto aux = producto[j];
                        producto[j] = producto[j + 1];
                        producto[j + 1] = aux;
                    }
                }
            }
            caro = producto[2].Nombre;
            barato = producto[0].Nombre;
            Console.WriteLine("Productos ordenados de menor a mayor por precio");
            for (int i= 0;i < 3;i++)
            {
                Console.WriteLine("Producto: " + producto[i].Nombre + " precio: " + producto[i].Precio + " Stock: " + producto[i].Stock);
            }
            Console.WriteLine("El producto mas caro es: " + caro + " y el producto mas barato es: " + barato);
        }

        static void Main(string[] args)
        {
            inventario i = new inventario();
            i.mostrarMenorAMayor();
        }
    }
}
