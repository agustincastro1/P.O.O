using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*1. Desarrollar una clase que represente un punto en el plano y tenga los
    siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
    encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
    positivas, si x<0 e y>0 segundo cuadrante, etc.)*/
    class Cuadrante
    {
        private int x;
        private int y;
        private string linea;
        public void cargarValores()
        {
                Console.WriteLine("Ingrese el valor de x: ");
                linea = Console.ReadLine();
                x = int.Parse(linea);

                Console.WriteLine("Ingrese el valor de y: ");
                linea = Console.ReadLine();
                y = int.Parse(linea);
        }

        public void imprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el primer cuadrante.");
            }
            if (x < 0 && y > 0)
            {
                Console.WriteLine("El punto se encuentra en el segundo cuadrante.");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el tercer cuadrante.");
            }
            if(x > 0 && y < 0)
            {
                Console.WriteLine("El punto se encuentra en el cuarto cuadrante.");
            }
        }
        static void Main(string[] args)
        {
            Cuadrante punto1 = new Cuadrante();
            punto1.cargarValores();
            punto1.imprimirCuadrante();

            Console.ReadKey();
        }
    }
}
