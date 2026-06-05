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
        private float velocidadMaxima;

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

        public float VelocidadMaxima
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

    }

    class Moto : Vehiculo
    {

        static void Main(string[] args)
        {
        }
    }
}
