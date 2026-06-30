using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
    Armar tres clases: Animal, Mamífero y Perro.
    La clase Animal debe tener un atributo especie.
    La clase Mamífero, que hereda de Animal, debe tener un atributo tipoAlimentacion.
    La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    Cada clase debe tener un constructor que reciba los datos correspondientes
    y los imprima indicando a qué clase pertenecen.
    Los datos deben ser asignados previamente
    Crear un objeto de la clase Perro y verificar la ejecución en cadena de los constructores. 
    */
    class Animal
    {
        string Especie;
        public string especie
        {
            set
            {
                Especie = value;
            }
            get
            {
                return Especie;
            }
        }
        public Animal(string especie)
        {
            Console.WriteLine("Especie: " + especie);
        }
    }

    class Mamifero : Animal
    {
        string tipoAlimentacion;
        private string TipoAlimentacion
        {
            set
            {
                tipoAlimentacion = value;
            }
            get
            {
                return tipoAlimentacion;
            }
        }
        public Mamifero(string especie, string tipoAlimentacion) : base(especie)
        {
            Console.WriteLine("tipo de alimentacion: " + TipoAlimentacion);
        }
    }

    class Perro : Mamifero
    {
        string Nombre;

        private string nombre
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
        public Perro(string especie, string tipoAlimentacion, string nombre) : base(especie, tipoAlimentacion)
        {
            Console.WriteLine("Nombre: " +  nombre);
        }
        static void Main(string[] args)
        {
            Perro p = new Perro("Canino", "Carnivoro", "Anda pa alla");
            Console.ReadKey();
        }
    }
}
