using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
    3. Fábrica de Computadoras (Herencia y Constructores con base)
Crear una clase base llamada Computadora que contenga los atributos Marca y
MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
Luego, definir dos clases derivadas de la clase base:
 Notebook: que añade el atributo propio TamañoPantalla (en pulgadas).
 Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.
    */
    class Computadora
    {
        private string marca;
        private int MemoriaRAM;
        public string Marca
        {
            set
            {
                marca = value;
            }
            get
            {
                return marca;
            }
        }

        public int memoriaRAM
        {
            set
            {
                MemoriaRAM = value;
            }
            get
            {
                return MemoriaRAM;
            }
        }

        public Computadora()
        {
            string linea;
            Console.WriteLine("ingrese la marca de su computadora: ");
            marca = Console.ReadLine();

            Console.WriteLine("ingrase la cantidad de RAM: ");
            linea = Console.ReadLine();
            memoriaRAM = int.Parse(linea);
        }
    }

    class Notebook : Computadora
    {
        private float TamañoPantalla;
        public Notebook()
        {
            string linea;
            Console.WriteLine("ingrese el tamaño de la pantalla: ");
            linea = Console.ReadLine();
            TamañoPantalla= float.Parse(linea);
        }
        
        public void imprimirNotebook()
        {
            Console.WriteLine("datos de la notebook: ");
            Console.WriteLine("Marca: " + Marca + " Cantidad de memoria RAM: " + memoriaRAM + "GB Tamaño de la pantalla: " + TamañoPantalla);  
        }
    }

    class Escritorio : Computadora
    {
        private int PotenciaFuente;
        public Escritorio()
        {
            string linea;
            Console.WriteLine("ingrese la potencia de la fuente: ");
            linea = Console.ReadLine();
            PotenciaFuente = int.Parse(linea);
        }

        public void imprimirEscritorio()
        {
            Console.WriteLine("datos PC de escritorio: ");
            Console.WriteLine("Marca: " + Marca + " Cantidad de memoria RAM: " + memoriaRAM + "GB Potencia de la fuente: " + PotenciaFuente);
        }
        static void Main(string[] args)
        {
            Notebook N = new Notebook();
            Escritorio E = new Escritorio();
            N.imprimirNotebook();
            E.imprimirEscritorio();
            Console.ReadKey();
        }
    }
}
