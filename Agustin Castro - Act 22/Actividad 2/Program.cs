using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
Definir una clase ElementoPantalla con atributos: nombre, posX y posY.
 Implementar propiedades y un constructor que cargue valores.
 Crear un método Mostrar() que use Console.SetCursorPosition() para ubicar el
nombre en pantalla y Console.CursorVisible para ocultar el cursor.
 Generar un vector de 4 elementos y mostrarlos en distintas posiciones en la
consola. 
    */
    class ElementoPantalla
    {
        private string nombre;
        private int posicionX;
        private int posicionY;

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

        public int PosicionX
        {
            set
            {
                posicionX = value;
            }
            get
            {
                return posicionX;
            }
        }

        public int PosicioY
        {
            set
            {
                posicionY = value;
            }
            get
            {
                return posicionY;
            }
        }

        public ElementoPantalla()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre de el punto en la consola:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el valor de la posicion X");
            linea = Console.ReadLine();
            posicionX = int.Parse(linea);

            Console.WriteLine("Ingrese el valor de la posicion Y");
            linea = Console.ReadLine();
            posicionY = int.Parse(linea);
        }
        public void Mostrar()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(posicionX, posicionY);
            Console.WriteLine(nombre);
        }
        static void Main(string[] args)
        {
            ElementoPantalla[] posiciones = new ElementoPantalla[4];
            posiciones[0] = new ElementoPantalla();
            posiciones[1] = new ElementoPantalla();
            posiciones[2] = new ElementoPantalla();
            posiciones[3] = new ElementoPantalla();
            Console.Clear();
            for (int i = 0; i < 4; i++)
            {
                posiciones[i].Mostrar();
            }
            Console.CursorVisible = true;
            Console.ReadKey();
        }
    }
}