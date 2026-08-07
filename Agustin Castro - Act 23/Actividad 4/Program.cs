using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
    4-

Un sistema central de domótica gestiona el consumo de los artefactos inteligentes
vinculados a una red hogareña.
 Crear la clase DispositivoInteligente que contenga como atributos
privados: nombreDispositivo (string) y consumoWatts (double). Definir
sus propiedades y un constructor que reciba nom y watts.
 Crear la clase colaboradora PanelDomotico que administre un objeto
List<DispositivoInteligente>.
 Métodos en PanelDomotico:
1. Un constructor que permita al usuario cargar dinámicamente
dispositivos por teclado. El sistema preguntará después de cada
carga si se desea agregar otro dispositivo.
2. MostrarDispositivos(): Listar todos los dispositivos
configurados junto a sus consumos.
3. CalcularConsumoTotal(): Calcular y mostrar en pantalla los
Watts totales que consume la casa sumando los valores de la lista.
4. DesconectarDispositivo(): Solicitar al usuario el nombre de
un dispositivo y, si existe en la lista, removerlo de forma dinámica
para simular su apagado remoto. 
    */
    class DispositivoInteligente
    {
        private string nombreDispositivo;
        private double consumoWatts;

        public string NombreDispositivo
        {
            set
            {
                nombreDispositivo = value;
            }
            get
            {
                return nombreDispositivo;
            }
        }

        public double ConsumoWatts
        {
            set
            {
                consumoWatts = value;
            }
            get
            {
                return consumoWatts;
            }
        }

        public DispositivoInteligente(string nom, double watts)
        {
            nombreDispositivo = nom;
            consumoWatts = watts;
        }
    }
    
    class PanelDomotico
    {
        List<DispositivoInteligente> dispositivos = new List<DispositivoInteligente>();

        public PanelDomotico()
        {
            for (int i = 0; i < 1;)
            {
            int watts = 0;
            string linea;
            Console.WriteLine("Nuevo dispositivo");
            Console.WriteLine("Ingrese el nombre del dispositivo");
            string nom = Console.ReadLine();
            Console.WriteLine("Ingrese los watts que tiene el dispositivo");
            linea = Console.ReadLine();
            watts = int.Parse(linea);

            DispositivoInteligente dispositivo = new DispositivoInteligente(nom, watts);

            dispositivos.Add(dispositivo);
            Console.WriteLine("Dispositivo agregado");

                Console.WriteLine("¿desea seguir agregando dispositivos? (Si / No)");
                linea = Console.ReadLine();
                if (linea == "si" || linea == "Si" || linea == "SI")
                {
                }
                if (linea == "no" || linea == "No" || linea == "NO")
                {
                    i++;
                }
            }
        }
        public void MostrarDispositivos()
        {
            if (dispositivos.Count > 0)
            {
            Console.WriteLine($"Lista de dispositivos ({dispositivos.Count}):");
            foreach (DispositivoInteligente dispositivo in dispositivos)
            {
                Console.WriteLine($"Nombre del dispositivo: {dispositivo.NombreDispositivo}");
                Console.WriteLine($"Watts del dispositivo: {dispositivo.ConsumoWatts}");
                Console.WriteLine("------------------------------------------------");
            }
            }
            else
            {
                Console.WriteLine("no hay dispositivos");
            }
        }

        public void CalcularConsumoTotal()
        {
            double total = 0;
            foreach (DispositivoInteligente dispositivo in dispositivos)
            {
                total = total + dispositivo.ConsumoWatts;
            }
            Console.WriteLine("consumo total de watts: " + total);
        }

        public void DesconectarDispositivo()
        {
            Console.WriteLine("Ingrese el dispositivo que quiere desconectar:");
            string linea = Console.ReadLine();
            bool encontro = false;
            for (int i = 0; i < dispositivos.Count; i++)
            {
                if (dispositivos[i].NombreDispositivo == linea)
                {
                    Console.WriteLine($"El dispositivo {dispositivos[i].NombreDispositivo} fue desconectada");
                    dispositivos.Remove(dispositivos[i]);
                    encontro = true;
                    break;
                }
            }
            if (encontro == false)
            {
                Console.WriteLine($"el dispositivo {linea} no se encontró. ");
            }
        }
        static void Main(string[] args)
        {
            PanelDomotico PN = new PanelDomotico();
            while (true)
            {
                string linea;
                int eleccion;
                Console.WriteLine("Eliga una opcion escribiendo su numero:");
                Console.WriteLine("1. Mostrar lista de dispositivos | 2. calcular consumo total | 3. desconectar dispositivo | 4. cerrar el panel");

                linea = Console.ReadLine();
                eleccion = int.Parse(linea);

                if (eleccion == 1)
                {
                    Console.Clear();
                    PN.MostrarDispositivos();
                }
                if (eleccion == 2)
                {
                    Console.Clear();
                    PN.CalcularConsumoTotal();
                }
                if (eleccion == 3)
                {
                    Console.Clear();
                    PN.DesconectarDispositivo();
                }
                if (eleccion == 4)
                {
                    Console.Clear();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
