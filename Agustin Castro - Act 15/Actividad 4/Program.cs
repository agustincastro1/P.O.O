using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
     Línea de Ensamblaje Robótico
En una planta de fabricación automatizada, cada robot industrial realiza tareas de
ensamblaje complejas divididas en operaciones secundarias de duración variable.
● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
1. ModeloRobot.
2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
fila representa una de las 4 fases principales del proceso (Estructura,
Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
completar las distintas subtareas de esa fase (por ejemplo, en la fase de
Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
1).
3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
cada una de las 4 fases de fabricación cuántas sub-tareas requirió realizar
(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
una de ellas.
● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
RobotEnsamblador. Implementar en PlantaIndustrial:
1. Un constructor que cargue la información de los 3 robots instalados en la
planta.
2. Un método que muestre un reporte detallado con los tiempos de operación
de cada robot fase por fase.
3. Un método que calcule el promedio general de tiempo por tarea de cada
robot y declare al "Robot más Eficiente"; (aquel que registre el promedio de
tiempo por operación más bajo de la planta).
     */
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

                for (int j = 0; j < fases.Length; j++)
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
            float[] promedio;
            promedio = new float[4];
            string nombreRobot = robots[0].retornarModelo();
            float suma;
            for (int i = 0; i < robots.Length; i++)
            {
                suma = 0;
                int cantidadTareas = 0;

                float[][] tiempos = robots[i].retornarTiempos();

                for (int j = 0; j < tiempos.Length; j++)
                {
                    for (int k = 0; k < tiempos[j].Length; k++)
                    {
                        suma = suma + tiempos[j][k];
                        cantidadTareas++;
                        promedio[i] = suma / cantidadTareas;
                    }
                }
                Console.WriteLine("Promedio del robot " + robots[i].retornarModelo() + ": " + promedio[i]);
            }
            float menorPromedio = promedio[0];
            for (int i = 0; i < robots.Length; i++)
            {
                if (promedio[i] < menorPromedio)
                {
                    menorPromedio = promedio[i];
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