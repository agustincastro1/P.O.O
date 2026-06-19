using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
    3.
Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
realice su asignación.
Luego, definir dos clases derivadas de la clase base:
● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
soportada en atmósferas).
● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
clase SondaExploradora mediante el uso explícito de la palabra clave base.
En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
parámetros unificados por consola. 
    */
    class SondaExploradora
    {
        private string modelo;
        private int autonomiaMinutos;
        public string Modelo
        {
            set
            {
                modelo = value;
            }

            get
            {
                return modelo;
            }
        }
        public int AutonomiaMinutos
        {
            set
            {
                autonomiaMinutos = value;
            }
            get
            {
                return autonomiaMinutos;
            }
        }
        public SondaExploradora()
        {
            string linea;
            Console.WriteLine("Ingrese el modelo de la sonda: ");
            modelo = Console.ReadLine();

            Console.WriteLine("Ingrese su autonomia en minutos: ");
            linea = Console.ReadLine();
            autonomiaMinutos = int.Parse(linea);
        }
    }
    class SondaMaritima : SondaExploradora
    {
        private int PresionMaximaAtm;

        public SondaMaritima()
        {
            string linea;
            Console.WriteLine("ingrese la presion atmosferica maxima que soporta: ");
            linea = Console.ReadLine();
            PresionMaximaAtm = int.Parse(linea);
        }                                       
        
        public void MostrarSondaMaritima()
        {
            Console.WriteLine("Sonda Maritima:");
            Console.WriteLine("Modelo: " + Modelo + " Autonomia en minutos: " + AutonomiaMinutos + " Presion maxima que soporta: " + PresionMaximaAtm);
        }
    }

    class RoverTerrestre : SondaExploradora 
    {
        private int CantRuedas;
        public RoverTerrestre()
        {
            string linea;
            Console.WriteLine("ingrese la cantidad de ruedas: ");
            linea = Console.ReadLine();
            CantRuedas = int.Parse(linea);
        }
        public void MostrarRTrerrestre()
        {
            Console.WriteLine("Rover Terrestre:");
            Console.WriteLine("Modelo: " + Modelo + " Autonomia en minutos: " + AutonomiaMinutos + " Cantidad de ruedas: " + CantRuedas);
        }
            static void Main(string[] args)
        {
            SondaMaritima SM = new SondaMaritima();
            SM.MostrarSondaMaritima();
            RoverTerrestre RT = new RoverTerrestre();
            RT.MostrarRTrerrestre();
            Console.ReadKey();
        }
    }
}
