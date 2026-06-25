using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{

    partial class JuegoArcade
    {
        private string NombreJuego;
        private int PuntajeMaximo;
        private int NivelDificultad;

        public string nombreJuego
        {
            set
            {
                NombreJuego = value;
            }
            get
            {
                return NombreJuego;
            }
        }
        
        public int puntajeMaximo
        {
            set
            {
                PuntajeMaximo = value;
            }
            get
            {
                return PuntajeMaximo;
            }
        }

        public int nivelDificultad
        {
            set
            {
                NivelDificultad = value;
            }
            get
            {
                return NivelDificultad;
            }
        }
        public JuegoArcade()
        {
            string linea;
            Console.WriteLine("Ingrese el nombre del juego:");
            NombreJuego = Console.ReadLine();

            Console.WriteLine("Ingrese el puntaje maximo del juego:");
            linea = Console.ReadLine();
            PuntajeMaximo = int.Parse(linea);
            for (int i = 0; i < 1; i++)
            {
            Console.WriteLine("Ingrese el nivel de dificultad del juego (1 a 5):");
            linea = Console.ReadLine();
                if (int.Parse(linea) >= 1 && int.Parse(linea) <= 5)
                {
                    NivelDificultad = int.Parse(linea);
                }
                else
                {
                    Console.WriteLine("el nivel de dificultad tiene que tener un valor entre 1 y 5");
                    i--;
                }
            }
        }
    }
}
