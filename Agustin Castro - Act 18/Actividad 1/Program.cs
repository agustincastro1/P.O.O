using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
    1.
Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
imprimir estos datos básicos.
Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
En el programa principal (Main):
● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
muestra de información. 
    */
    class DispositivoEnergia
    {
        private string CodigoIdentificador;
        private double GeneracionKwh;

        public string codigoIdentificador
        {
            set
            {
                CodigoIdentificador = value;
            }
            get
            {
                return CodigoIdentificador;
            }
        }

        public double generacionKwh
        {
            set
            {
                GeneracionKwh = value;
            }
            get
            {
                return GeneracionKwh;
            }
        }

        public DispositivoEnergia()
        {
            string linea;
            Console.WriteLine("Ingrese el codigo identificador del dispositivo");
            CodigoIdentificador = Console.ReadLine();

            Console.WriteLine("Ingrese la cantidad de Kilowatts por hora (sin valores negativos)");
            linea = Console.ReadLine();
            if (double.Parse(linea) >= 0)
            {
                GeneracionKwh = double.Parse(linea);
            }
            else
            {
                GeneracionKwh = 0;
            }
        }
        public void imprimirDatosDispositivo()
        {
            Console.WriteLine("Codigo de dispositivo: " + CodigoIdentificador);
            Console.WriteLine("Generacion Kilowatts por hora: " + GeneracionKwh);
        }
    }
    class PanelSolar : DispositivoEnergia
    {
        private double AreaMetros;
        public PanelSolar()
        {
            for (int i = 0; i < 1; i++)
            {
                string linea;
                Console.WriteLine("ingrese el Area en metros del panel solar:");            
                linea = Console.ReadLine();
                if (double.Parse(linea) > 0)
                {
                    AreaMetros = double.Parse(linea);
                }
                else
                {
                    Console.WriteLine("El area tiene que ser mayor a 0:");
                    i--;
                }
            }
        }

        public void imprimirDatosPanel()
        {
            Console.WriteLine("Codigo del Panel: " + codigoIdentificador);
            Console.WriteLine("Generacion KiloWatts por hora: " + generacionKwh);
            Console.WriteLine("Area del panel: " + AreaMetros);
        }
        static void Main(string[] args)
        {
            DispositivoEnergia DI = new DispositivoEnergia();
            DI.imprimirDatosDispositivo();
            PanelSolar PS = new PanelSolar();
            PS.imprimirDatosPanel();
            Console.ReadKey();
        }
    }
}
