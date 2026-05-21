using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
     1. Confeccionar una clase que represente un empleado. Definir como atributos su
        nombre y su sueldo. En el constructor cargar los atributos y luego en otro
        método imprimir sus datos y por último uno que imprima un mensaje si debe
        pagar impuestos (si el sueldo supera a 3000)
     */
    class empleado
    {
        private string nombre;
        private int sueldo;

        public empleado()
        {
            string linea;
            Console.WriteLine("ingrese un nombre");
            linea = Console.ReadLine();
            nombre = linea;

            Console.WriteLine("ingrese un sueldo");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void imprimirDatos()
        {
            Console.WriteLine("el sueldo de: " + nombre + " es: " + sueldo);
        }

        public void impuestos()
        {
            if (sueldo >= 3000)
            {
                Console.WriteLine(nombre + " debe pagar impuestos");
            }
            else
            {
                Console.WriteLine(nombre + " no debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
                empleado e = new empleado();
                e.imprimirDatos();
                e.impuestos();
                Console.ReadKey();
        }
    }
}
