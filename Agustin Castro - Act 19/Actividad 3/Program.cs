using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
3. Armar una clase parcial JuegoArcade.
En el primer archivo, definir las propiedades NombreJuego, PuntajeMaximo, y
NivelDificultad (de 1 a 5). Valores cargados desde consola
En el segundo archivo, implementar un método que indique si un puntaje ingresado
supera el récord o no.
Desde Main, simular 4 partidas, mostrar qué jugador rompió el récord de su juego. 
    */
    internal class Program
    {
        public JuegoArcade[] juegos;
        public Program()
        {
            juegos = new JuegoArcade[4];
            for (int i = 0; i < juegos.Length; i++)
            {
                juegos[i] = new JuegoArcade();
            }
        }

        public void record()
        {
            int puntajeRecord = 300;
            for (int i = 0;i < juegos.Length; i++)
            {
                if (juegos[i].puntajeMaximo > puntajeRecord)
                {
                    Console.WriteLine("El jugador: " + (i+1) + " superó el record");
                }
            }
        }
        static void Main(string[] args)
        {
            Program P = new Program();
            P.record();
            Console.ReadKey();
        }
    }
}
