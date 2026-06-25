using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
        1. Plantear una clase parcial ReservaHotel.
En el primer archivo, definir las propiedades NombreCliente, CantidadNoches y
TipoHabitacion (puede ser “Simple”, “Doble” o “Suite”), validando que la cantidad de
noches sea mayor a 0. Estos valores son cargados desde la consola.
En el segundo archivo, agregar un método que calcule el total a pagar según la
habitación elegida (por ejemplo: Simple = $5000, Doble = $8000, Suite = $12000 por
noche).
Desde la clase principal, cargar 3 reservas y mostrar cuál cliente pagará más. 
    */
    class Program
    {
        public ReservaHotel[] reservas;
        public Program()
        {
            reservas = new ReservaHotel[3];
            for (int i = 0; i < reservas.Length; i++)
            {
                reservas[i] = new ReservaHotel();
            }
        }
        public void CalcularPago()
        {
            for (int i = 0; i < 3; i++)
            {
                reservas[i].CantidadPago = reservas[i].CantidadPago * reservas[i].CantidadNoches;
            }
            for (int i = 0;i < reservas.Length;i++)
            {
                for(int j = 0; j < reservas.Length - i -1; j++)
                {
                    if (reservas[j].CantidadPago < reservas[j+1].CantidadPago)
                    {
                        ReservaHotel aux = reservas[j];
                        reservas[j] = reservas[j + 1];
                        reservas[j + 1] = aux;
                    }
                }       
            }
            Console.WriteLine("Clientes ordenados por precio de reserva:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Nombre: " + reservas[i].NombreCliente + " Precio: $" + reservas[i].CantidadPago);
            }
            Console.WriteLine("Cliente que mas pago:");
            Console.WriteLine("Nombre: " + reservas[0].NombreCliente + " Precio: $" + reservas[0].CantidadPago);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.CalcularPago();
            Console.ReadKey();
        }
    }
}
