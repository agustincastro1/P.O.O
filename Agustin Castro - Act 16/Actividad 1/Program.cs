using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
    Confeccionar una clase Persona que tenga como atributos el nombre y la edad (definir las propiedades para poder acceder a dichos atributos).
    Definir un método para imprimirlos. Plantear una segunda clase Empleado que herede de la clase Persona.
    Añadir un atributo sueldo ( y su propiedad) y el método para imprimir su sueldo.
    Definir un objeto de la clase Persona y llamar a sus métodos y propiedades.
    También crear un objeto de la clase Empleado y llamar a sus métodos y propiedades.
     */
    class Persona
    {
        private string nombre;
        private int edad;

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

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }

        public void imprimirPersona()
        {
            Console.WriteLine(nombre + " tiene " + edad + " años.");
        }
    }
    class empleado : Persona 
    {
        private int sueldo;
        
        public int Sueldo
        {
            set
            {
                sueldo = value;
            }

            get
            {
                return sueldo;
            }
        }

        public void imprimirEmpleado()
        {
            Console.WriteLine(Nombre + " tiene " + Edad + " años y su sueldo es de: " + sueldo);
        }

        static void Main(string[] args)
        {
            Persona persona1 = new Persona();
            persona1.Nombre = "Juan";
            persona1.Edad = 1;
            persona1.imprimirPersona();
            Persona persona2 = new Persona();
            persona2.Nombre = "Ana";
            persona2.Edad = 2;
            persona2.imprimirPersona();
            empleado empleado1 = new empleado();
            empleado1.Nombre = "Pedro";
            empleado1.Edad = 3;
            empleado1.Sueldo = 4;
            empleado1.imprimirEmpleado();
            empleado empleado2 = new empleado();
            empleado2.Nombre = "Santino";
            empleado2.Edad = 4;
            empleado2.Sueldo = 3000000;
            empleado2.imprimirEmpleado();
            Console.ReadKey();
        }
    }
}
