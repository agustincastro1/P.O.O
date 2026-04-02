using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
    4. Implementar la clase operaciones. Se deben cargar dos valores enteros,
    calcular su suma, resta, multiplicación y división, cada una en un método,
    imprimir dichos resultados.
    */
    class Operaciones
    {
        private int valor1, valor2;
        private string linea;
        public void cargarValores()
        {
            Console.WriteLine("Ingrese el primer valor: ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            Console.WriteLine("Ingrese el segundo valor: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }

        public void inprimirSuma()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("La suma es: " + suma);
        }
        
        public void imprimirResta()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("La resta es: " + resta);
        }

        public void imprimirMultiplicacion()
        {
            int multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicación es: " + multiplicacion);
        }

        public void imprimirDivision()
        {
                double division = valor1 / valor2;
                Console.WriteLine("La división es: " + division);
        }
        static void Main(string[] args)
        {
            Operaciones operacion = new Operaciones();
            operacion.cargarValores();
            operacion.inprimirSuma();
            operacion.imprimirResta();
            operacion.imprimirMultiplicacion();
            operacion.imprimirDivision();

            Console.ReadKey();
        }
    }
}
