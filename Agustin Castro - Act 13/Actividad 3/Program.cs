using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
        3. Plantear una clase Club y otra clase Socio.
           La clase Socio debe tener los siguientes atributos privados: nombre y la
           antigüedad en el club (en años). En el constructor pedir la carga del nombre y
           su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
           Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
           antigüedad en el club.
     */
    class Socio
    {
        private string nombre;
        private int antigüedad;

        public Socio()
        {
            string linea;
            Console.WriteLine("ingrese el nombre del socio: ");
            linea = Console.ReadLine();
            nombre = linea;

            Console.WriteLine("ingrese los años que tiene en el club");
            linea = Console.ReadLine();
            antigüedad = int.Parse(linea);
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public int returnarAntigüedad()
        {
            return antigüedad;
        }

    }
    class club
    {
        private Socio socio1, socio2, socio3;
        private int mayorAnt;
        private string nomMayorAnt;

        public club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }

        public void mayorAntigüedad()
        {
            mayorAnt = socio1.returnarAntigüedad();
            nomMayorAnt = socio1.retornarNombre();

            if (mayorAnt < socio2.returnarAntigüedad())
            {
                mayorAnt = socio2.returnarAntigüedad();
                nomMayorAnt = socio2.retornarNombre();
            }
            if (mayorAnt < socio3.returnarAntigüedad())
            {
                mayorAnt = socio3.returnarAntigüedad();
                nomMayorAnt = socio3.retornarNombre();
            }

            Console.WriteLine("el socio con mayor antigüedad es: " + nomMayorAnt + " con: " + mayorAnt + " años de antigüedad");
        }

        static void Main(string[] args)
        {
            club c = new club();
            c.mayorAntigüedad();
            Console.ReadKey();
        }
    }
}
