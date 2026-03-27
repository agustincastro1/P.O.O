using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* Realizar un programa que lea los lados de n triángulos, e informar:
            a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
            iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
            b) Cantidad de triángulos de cada tipo.
            c) Tipo de triángulo que posee menor cantidad. */

            int lado1, lado2, lado3, triangulos, equilateros = 0, isósceles = 0, escalenos = 0;
            Console.WriteLine("ingrese una canditdad de triangulos: ");
            triangulos = int.Parse(Console.ReadLine());
            for (int i = 0; i < triangulos; i++)
            {
                Console.WriteLine("ingrese el primer lado del triangulo: ");
                lado1 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el segundo lado del triangulo: ");
                lado2 = int.Parse(Console.ReadLine());

                Console.WriteLine("ingrese el tercer lado del triangulo: ");
                lado3 = int.Parse(Console.ReadLine());

                if (lado1 != lado2 && lado1 != lado3 && lado3 != lado2)
                {
                    Console.WriteLine("es un triangulo escaleno\n");
                    escalenos++;
                }
                if (lado1 == lado2 && lado1 == lado3)
                {
                    Console.WriteLine("es un triangulo equilatero\n");
                    equilateros++;
                }
                if ((lado1 == lado2 && lado1 != lado3) || (lado1 == lado3 && lado1 != lado2) || (lado2 == lado3 && lado2 != lado1))
                {
                    Console.WriteLine("es un triangulo isósceles\n");
                    isósceles++;
                }
                if (i != triangulos -1)
                {
                    Console.WriteLine("\nescriba los lados del sieguiente triangulo");
                }    
            }
            if(isósceles < escalenos && isósceles < equilateros)
                {
                    Console.WriteLine("\nel tipo de triangulo con menor cantidad es el isósceles");
                }
                if (isósceles > escalenos && escalenos < equilateros)
                {
                    Console.WriteLine("\nel tipo de triangulo con menor cantidad es el escaleno");
                }
                if (isósceles > equilateros && escalenos > equilateros)
                {
                    Console.WriteLine("\nel tipo de triangulo con menor cantidad es el equilatero");
                }
            
            Console.ReadKey();
        }
    }
}
