using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
     4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
herencia: Material, Herramienta y Martillo.
 La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
Plástico).
 La clase Herramienta (que hereda de Material) debe añadir el atributo
FuncionPrincipal.
 La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
(ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).
En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
en cadena de los constructores (desde la raíz hasta la clase derivada).
    */
    class material
    {
        protected string tipoMaterial;

        public string TipoMaterial
        {
            set
            {
                tipoMaterial = value;
            }
            get
            {
                return tipoMaterial;
            }
        }

        public material()
        {
            Console.WriteLine("Ingrese el tipo de material:");
            tipoMaterial = Console.ReadLine();
            Console.WriteLine("pertenece a la clase material");
        }
    }

    class herramienta : material
    {
        private string funcionPrincipal;

        public string FuncionPrincipal
        {
            set
            {
                funcionPrincipal = value;
            }
            get
            {
                return funcionPrincipal;
            }
        }

        public herramienta()
        {
            Console.WriteLine("Ingrese la funcion principal de la herramienta:");
            funcionPrincipal = Console.ReadLine();
            Console.WriteLine("Pertenece a la clase herramienta");
        }
    }

    class martillo : herramienta 
    {
        private int pesoGramos;

        public martillo()
        {
            string linea;
            Console.WriteLine("ingrese el peso en gramos del martillo:");
            linea = Console.ReadLine();
            pesoGramos = int.Parse(linea);
            Console.WriteLine("Pertenece a la clase martillo");
        }
        static void Main(string[] args)
        {
            martillo mar = new martillo();
            Console.WriteLine("Material: " + mar.TipoMaterial + " Funcion Principal: " + mar.FuncionPrincipal + " Peso en gramos: " + mar.pesoGramos);
            Console.ReadKey();
        }
    }
}
