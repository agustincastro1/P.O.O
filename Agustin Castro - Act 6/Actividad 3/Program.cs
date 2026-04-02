using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*3. Confeccionar una clase que represente un empleado. Definir como atributos su
    nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
    sus datos y por último uno que imprima un mensaje si debe pagar impuestos
    (si el sueldo supera a 3000).
    */
    class Empleado
    {
        int sueldo;
        string linea, nombre;
        public void cargarAtributos()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el sueldo del empleado: ");
            linea = Console.ReadLine();
            sueldo = int.Parse(linea);
        }

        public void imprimirDatos()
        {
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Sueldo: " + sueldo);
        }

        public void impuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine(nombre + " debe pagar impuestos.");
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.cargarAtributos();
            empleado.imprimirDatos();
            empleado.impuestos();

            Console.ReadKey();
        }
    }
}
