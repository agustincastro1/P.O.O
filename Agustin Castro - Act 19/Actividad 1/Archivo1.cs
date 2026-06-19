using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    partial class ReservaHotel
    {
        private string nombreCliente;
        private int cantidadNoches;
        private string tipoHabitacion;
        private int cantidadPago;

        public string NombreCliente
        {
            set
            {
                nombreCliente = value;
            }
            get
            {
                return nombreCliente;
            }
        }
        public int CantidadNoches
        {
            set
            {
                cantidadNoches = value;
            }
            get
            {
                return cantidadNoches;
            }
        }
        public string TipoHabitacion
        {
            set
            {
                tipoHabitacion = value;
            }
            get
            {
                return tipoHabitacion;
            }
        }

        public int CantidadPago
        {
            set
            {
                cantidadPago = value;
            }
            get
            {
                return cantidadPago;
            }
        }
        public ReservaHotel()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del cliente: ");
            nombreCliente = Console.ReadLine();

            for (int i = 0; i < 1; i++)
            {
            Console.WriteLine("Ingrese la cantidad de noches (mayor a 0):");
            linea = Console.ReadLine();
                if (int.Parse(linea) > 0)
                {
                    cantidadNoches = int.Parse(linea);
                }
                else
                {
                    Console.WriteLine("La cantidad de noches tienen que ser mayores a 0");
                    i--;
                }
            }
            for (int i = 0;i < 1; i++)
            {
                Console.WriteLine("Ingrese el tipo de habitacion (Simple, Doble o Suite):");
                linea = Console.ReadLine(); 
                if(linea == "Simple")
                {
                    tipoHabitacion = linea;
                    cantidadPago = 5000;
                }
                else
                {
                    if (linea == "Doble")
                    {
                        tipoHabitacion = linea;
                        cantidadPago = 8000;
                    }
                    else
                    {
                        if (linea == "Suite")
                        {
                            tipoHabitacion = linea;
                            cantidadPago = 12000;
                        }
                        else
                        {
                            Console.WriteLine("Ingrese una habitacion valida");
                            i--;
                        }
                    }
                }
            }
            
        }
    }
}
