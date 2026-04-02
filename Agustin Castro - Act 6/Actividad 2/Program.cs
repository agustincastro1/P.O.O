using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*2. Desarrollar una clase que represente un Cuadrado y tenga los siguientes
    métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
    */
    class Cuadrado
    {
        private int lado;
        private string linea;
        public void cargarValorLado()
        {
            Console.WriteLine("Ingrese el valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
        }

        public void imprimirPerimetro()
        {
            int perimetro = lado * 4;
            Console.WriteLine("El perímetro del cuadrado es: " + perimetro);
        }
        
        public void imprimirSuperficie()
        {   
            int superficie = lado * lado;
            Console.WriteLine("La superficie del cuadrado es: " + superficie);
        }
        static void Main(string[] args)
        {
            Cuadrado cuadrado = new Cuadrado();
            cuadrado.cargarValorLado();
            cuadrado.imprimirPerimetro();
            cuadrado.imprimirSuperficie();

            Console.ReadKey();
        }
    }
}
