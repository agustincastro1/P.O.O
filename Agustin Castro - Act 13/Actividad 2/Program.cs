using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
        2. Implementar la clase operaciones. Se deben cargar dos valores enteros en el
            constructor, calcular su suma, resta, multiplicación y división, cada una en un
            método, imprimir dichos resultados.
    */
    class operaciones
    {
        private int valor1;
        private int valor2;
        private int suma;
        private int resta;
        private int multiplicacion;
        private float division;

        public operaciones()
        {
            string linea;
            Console.WriteLine("ingrese un valor");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            Console.WriteLine("ingrese un valor");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);
        }

        public void calcularSuma()
        {
            suma = valor1 + valor2;
        }

        public void calcularResta()
        {
            resta = valor1 - valor2;
        }

        public void calcularMultiplicacion()
        {
            multiplicacion = valor1 * valor2;
        }

        public void calcularDivision()
        {
            division = (float)valor1 / (float)valor2;
        }

        public void imprimir()
        {
            Console.WriteLine("Operaciones con los 2 valores:");
            Console.WriteLine(suma);
            Console.WriteLine(resta);
            Console.WriteLine(multiplicacion);
            Console.WriteLine(division);
        }

        static void Main(string[] args)
        {
            operaciones op = new operaciones();
            op.calcularSuma();
            op.calcularResta();
            op.calcularMultiplicacion();
            op.calcularDivision();
            op.imprimir();
            Console.ReadKey();
        }
    }
}
