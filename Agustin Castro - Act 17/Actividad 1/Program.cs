using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
    1. Personal de un Gimnasio (Herencia Simple y Propiedades)
Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
método para imprimir estos datos básicos.
Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
para imprimir todos los datos del profesor (incluyendo los heredados).
En el programa principal (Main):
 Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
llamar a su método de impresión.
 Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
que puede acceder tanto a sus métodos propios como a los de la clase base.
    */
    class PersonaGimnasio
    {
        private string Nombre;
        private int DNI;
        public string nombre
        {
            set
            {
                Nombre = value;
            }
            get
            {
                return Nombre;
            }
        }
        public int dni
        {
            set
            {
                DNI = value;
            }
            get
            {
                return DNI;
            }
        }

        public void imprimirDatos()
        {
            Console.WriteLine("Datos de persona: ");
            Console.WriteLine("Nombre: " + Nombre + " DNI: " + DNI);
        }
    }

    class Profesor : PersonaGimnasio
    {
        private string Especialidad;
        public string especialidad
        {
            set
            {
                Especialidad = value;
            }
            get
            {
                return Especialidad;
            }
        }

        public void imprimirDatos2()
        {
            Console.WriteLine("Datos del Profesor:");
            Console.WriteLine("Nombre: " + nombre + " DNI: " + dni + " Especialidad: " + especialidad);
        }
        static void Main(string[] args)
        {
            PersonaGimnasio Pg = new PersonaGimnasio();
            Pg.nombre = "Carlos";
            Pg.dni = 67676767;
            Pg.imprimirDatos();
            Profesor P = new Profesor();
            P.nombre = "Tacho";
            P.dni = 89898989;
            P.especialidad = "Tren superior";
            P.imprimirDatos2();
            Console.ReadKey();
        }
    }
}
