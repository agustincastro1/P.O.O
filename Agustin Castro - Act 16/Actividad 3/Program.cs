using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
    Crear una clase base Vehículo que contenga atributos marca y velocidadMaxima.
    Definir dos clases derivadas:
    Auto y Moto, que hereden de Vehículo. 
    Cada una debe tener un constructor que reciba los valores de los atributos base mediante la palabra clave base,
    y un atributo propio (cantidadPuertas en Auto, cilindrada en Moto).
    Crear un objeto de cada clase y mostrar todos sus datos por consola.
     */
    class Vehiculo
    {
        private string marca;
        private string velocidadMaxima;

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

        public string VelocidadMaxima
        {
            set
            {
                velocidadMaxima = value;
            }
            get
            {
                return velocidadMaxima;
            }
        }

    }
    class Auto : Vehiculo
    {
        private string CantidadPuertas;
        private string[] baseAuto;
        
        public Auto()
        {
            baseAuto = new string[3];

            Console.WriteLine("ingrese la Marca del auto:");
            Marca = Console.ReadLine();
            baseAuto[0] = Marca;

            Console.WriteLine("ingrese la velocidad maxima del auto (km/h):");
            VelocidadMaxima = Console.ReadLine();
            baseAuto[1] = VelocidadMaxima;

            Console.WriteLine("ingrese la cantidad de puertas que tiene el auto");
            CantidadPuertas = Console.ReadLine();
            baseAuto[2] = CantidadPuertas;
        }
        public void mostrarDatosAuto()
        {
            Console.WriteLine("Datos del Auto:");
                Console.WriteLine("Marca: " + baseAuto[0] + " Velocidad Maxima: " + baseAuto[1] + " Cantidad De Puertas: " + baseAuto[2]);
        }
    }

    class Moto : Vehiculo
    {
        private string cilindrada;
        private string[] baseMoto;
        public Moto()
        {
            baseMoto = new string[3];

            Console.WriteLine("ingrese la marca de la Moto:");
            Marca = Console.ReadLine();
            baseMoto[0] = Marca;

            Console.WriteLine("ingrese la velocidad maxima de la Moto:");
            VelocidadMaxima = Console.ReadLine();
            baseMoto[1] = VelocidadMaxima;

            Console.WriteLine("ingrese la cilindrada de la Moto:");
            cilindrada = Console.ReadLine();
            baseMoto[2] = cilindrada;
        }
        public void mostrarDatosMoto()
        {
            Console.WriteLine("Datos de la Moto:");
            Console.WriteLine("Marca: " + baseMoto[0] + " Velocidad Maxima: " + float.Parse(baseMoto[1]) + " Cilindrada: " + int.Parse(baseMoto[2]));
        }

        static void Main(string[] args)
        {
            Auto auto = new Auto();
            Moto moto = new Moto();
            auto.mostrarDatosAuto();
            moto.mostrarDatosMoto();
            Console.ReadKey();
        }
    }
}
