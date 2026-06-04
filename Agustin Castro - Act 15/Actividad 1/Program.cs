using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
     1. Monitoreo Clínico de Pacientes
        En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo cardíaco de los pacientes.
            ● Plantear una clase llamada Paciente que tenga como atributos privados:
                1. Nombre (de tipo string).
                2. Una matriz llamada ritmoCardiaco de tamaño 3x4 (representando los registros
                   de pulsaciones tomados durante 3 días diferentes, en 4 momentos
                   clave de cada día: mañana, mediodía, tarde y noche).
                3. El constructor de Paciente debe pedir su nombre y solicitar la carga por teclado de las 12 lecturas cardíacas.

            ● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de objetos de la clase Paciente.
              Su constructor debe inicializar el vector y solicitar la carga de los 3 pacientes.
              
        Implementar los siguientes métodos dentro de SalaMonitoreo:
            1. Un método que imprima la grilla de lecturas cardíacas completa de cada paciente organizada por día y momento.
            2. Un método que calcule e imprima el promedio de pulsaciones de cada paciente a lo largo de todo su monitoreo.
            3. Un método que verifique si algún paciente registró un evento de taquicardia severa 
               (cualquier lectura individual que sea estrictamente mayor a 120 pulsaciones)
               mostrando por consola su nombre y la lectura detectada.
     */
    class Paciente
    {
        private string nombre;
        private int[,] ritmoCardiaco;
        
        public Paciente()
        {
            ritmoCardiaco = new int [3,4];

            string linea;
            Console.WriteLine("Ingrese el nombre del paciente: ");
            linea = Console.ReadLine();
            nombre = linea;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine("ingrese un ritmo cardiaco:");
                    linea = Console.ReadLine();
                    ritmoCardiaco[i,j] = int.Parse(linea);
                }
            }

        }
        public string retornarNombre()
        {
            return nombre;
        }

        public int[,] retornarPulsaciones()
        {
                return ritmoCardiaco;
        }

    }
    class salaMonitoreo
    {
        private Paciente[] pacientes;
            public salaMonitoreo()
            { 
                pacientes = new Paciente[3];
                for (int i = 0; i < 3; i++)
                {
                    pacientes[i] = new Paciente();
                }
            }
        public void imprimirGrilla()
        {
            string[] momentos = { "Mañana", "Mediodía", "Tarde", "Noche" };

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Paciente: " + pacientes[i].retornarNombre());
                int[,] pulsaciones = pacientes[i].retornarPulsaciones();

                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("  Día " + (j + 1) + ":");
                    for (int f = 0; f < 4; f++)
                    {
                        Console.WriteLine(momentos[f] + ": " + pulsaciones[j, f]);
                    }
                }
            }
        }

        public void calcularPromedio()
        {
            for (int i = 0;i < 3; i++)
            {
                float suma = 0;
                int[,] pulsaciones = pacientes[i].retornarPulsaciones();
                for (int d = 0; d < 3; d++)
                {
                    for (int m = 0; m < 4; m++)
                    {
                        suma = suma + pulsaciones[d, m];
                    }
                }
                float promedio = suma / 12;
                Console.WriteLine("Promedio de pulsaciones del paciente " + pacientes[i].retornarNombre() + ": " + promedio);
            }
        }

        public void verificarTaquicardia()
        {
            for (int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    for (int f = 0; f < 4; f++)
                    {
                        int lectura = pacientes[i].retornarPulsaciones()[j, f];
                        if (lectura > 120)
                        {
                            Console.WriteLine("el Paciente " + pacientes[i].retornarNombre() + " registró taquicardia con una lectura de: " + lectura);
                        }
                    }
                }
            }
        }
        static void Main(string[] args)
        {
                salaMonitoreo sala = new salaMonitoreo();
                sala.imprimirGrilla();
                sala.calcularPromedio();
                sala.verificarTaquicardia();
            Console.ReadKey();
        }
    }
}
