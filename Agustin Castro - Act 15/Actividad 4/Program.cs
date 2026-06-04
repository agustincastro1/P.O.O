using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    class RobotEnsamblador
    {
        private string modeloRobot;
        private float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

            Console.WriteLine("Ingrese el modelo del robot:");
            modeloRobot = Console.ReadLine();

            tiemposOperacion = new float[4][];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("¿Cuántas subtareas tuvo la fase " + fases[i] + "?");
                int cantidad = int.Parse(Console.ReadLine());

                tiemposOperacion[i] = new float[cantidad];

                for (int j = 0; j < cantidad; j++)
                {
                    Console.WriteLine("Ingrese el tiempo de la subtarea " + (j + 1) + ":");
                    tiemposOperacion[i][j] = float.Parse(Console.ReadLine());
                }
            }
        }

        public string retornarModelo()
        {
            return modeloRobot;
        }

        public float[][] retornarTiempos()
        {
            return tiemposOperacion;
        }
    }

    class PlantaIndustrial
    {
        private RobotEnsamblador[] robots;

        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];

            for (int i = 0; i < robots.Length; i++)
            {
                robots[i] = new RobotEnsamblador();
            }
        }

        public void mostrarReporte()
        {
            string[] fases = { "Estructura", "Cableado", "Pintura", "Testeo" };

            for (int i = 0; i < robots.Length; i++)
            {
                Console.WriteLine("Robot: " + robots[i].retornarModelo());

                float[][] tiempos = robots[i].retornarTiempos();

                for (int j = 0; j < tiempos.Length; j++)
                {
                    Console.WriteLine("Fase: " + fases[j]);

                    for (int k = 0; k < tiempos[j].Length; k++)
                    {
                        Console.WriteLine("Subtarea " + (k + 1) + ": " + tiempos[j][k] + " segundos");
                    }
                }

                Console.WriteLine();
            }
        }

        public void robotMasEficiente()
        {
            float menorPromedio = 0;
            string nombreRobot = "";

            for (int i = 0; i < robots.Length; i++)
            {
                float suma = 0;
                int cantidadTareas = 0;

                float[][] tiempos = robots[i].retornarTiempos();

                for (int j = 0; j < tiempos.Length; j++)
                {
                    for (int k = 0; k < tiempos[j].Length; k++)
                    {
                        suma += tiempos[j][k];
                        cantidadTareas++;
                    }
                }

                float promedio = suma / cantidadTareas;

                Console.WriteLine("Promedio del robot "
                    + robots[i].retornarModelo()
                    + ": "
                    + promedio);

                if (i == 0 || promedio < menorPromedio)
                {
                    menorPromedio = promedio;
                    nombreRobot = robots[i].retornarModelo();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Robot más eficiente: " + nombreRobot);
            Console.WriteLine("Promedio de tiempo por operación: " + menorPromedio);
        }

        static void Main(string[] args)
        {
            PlantaIndustrial planta = new PlantaIndustrial();

            planta.mostrarReporte();
            planta.robotMasEficiente();

            Console.ReadKey();
        }
    }
}