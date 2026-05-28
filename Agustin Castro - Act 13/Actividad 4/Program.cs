using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_4
{
    /*
     4. Plantear una clase Alumno que tenga los atributos privados: nombre y vector de 4 notas. 
        Definir un constructor que solicite el ingreso del nombre del alumno y sus 4 calificaciones.
        Luego, confeccionar una clase Curso que contenga un vector de 3 objetos Alumno.
        Agregar los siguientes métodos:
            a) Un método que imprima el nombre de cada alumno y su promedio.
            b) Un método que muestre el nombre del alumno con el promedio más alto.
            c) Un método que indique qué alumnos tienen al menos una nota desaprobada (nota menor a 6)
     */
    class Alumno
    {
        private string nombre;
        private int[] notas;
        

        public Alumno()
        {
            notas = new int[4];
            string linea;
            Console.WriteLine("ingrese el nombre del alumno:");
            linea = Console.ReadLine();
            nombre = linea;
            for (int i = 0; i < notas.Length; i ++)
            {
            Console.WriteLine("ingrese la nota del alumno");
            linea = Console.ReadLine();
            notas[i] = int.Parse(linea);
            }
        }
        public string retornarNombre()
        {
            return nombre;
        }
        public int[] retornarNotas()
        {
            return notas;
        }
    }

    class Curso
    {
        private Alumno alumno1, alumno2, alumno3;
        int[] A1;
        int[] A2;
        int[] A3;
        public Curso()
        {
            alumno1 = new Alumno();
            alumno2 = new Alumno();
            alumno3 = new Alumno();
        }

        public void imprimirPromedios()
        {
            A1 = alumno1.retornarNotas();
            A2 = alumno2.retornarNotas();
            A3 = alumno3.retornarNotas();
            Console.WriteLine("El Alumno: " + alumno1.retornarNombre() + " tiene un Promedio de: " + A1.Average());
            Console.WriteLine("El Alumno: " + alumno2.retornarNombre() + " tiene un Promedio de: " + A2.Average());
            Console.WriteLine("El Alumno: " + alumno3.retornarNombre() + " tiene un Promedio de: " + A3.Average());
        }

        public void alumnoMayorPromedio()
        {
            if (A1.Average() > A2.Average() && A1.Average() > A3.Average())
            {
                Console.WriteLine("El alumno con el mayor promedio es: " + alumno1.retornarNombre());
            }
                else if (A2.Average() > A1.Average() && A2.Average() > A3.Average())
                {
                Console.WriteLine("El alumno con el mayor promedio es: " + alumno2.retornarNombre());
                }
                    else
                    {
                    Console.WriteLine("El alumno con el mayor promedio es: " + alumno3.retornarNombre());
                    }
        }

        public void alumnosDesaprobados()
        {
            string[] NotaDesaprobada;
            NotaDesaprobada = new string[3];
            for (int j = 0; j < 4; j++)
            {
                if (alumno1.retornarNotas()[j] < 6)
                {
                    NotaDesaprobada[0] = alumno1.retornarNombre();
                }
            }
            for (int j = 0; j < 4; j++)
            {
                if (alumno2.retornarNotas()[j] < 6)
                {
                    NotaDesaprobada[1] = alumno2.retornarNombre();
                }
            }
            for (int j = 0; j < 4; j++)
            {
                if (alumno3.retornarNotas()[j] < 6)
                {
                    NotaDesaprobada[2] = alumno3.retornarNombre();
                }
            }

            if (NotaDesaprobada[0] != null)
            {
                Console.WriteLine("El alumno: " + NotaDesaprobada[0] + " tiene al menos una nota desaprobada");
            }
            if (NotaDesaprobada[1] != null)
            {
                Console.WriteLine("El alumno: " + NotaDesaprobada[1] + " tiene al menos una nota desaprobada");
            }
            if (NotaDesaprobada[2] != null)
            {
                Console.WriteLine("El alumno: " + NotaDesaprobada[2] + " tiene al menos una nota desaprobada");
            }
        }

        static void Main(string[] args)
        {
            Curso c = new Curso();
            c.imprimirPromedios();
            c.alumnoMayorPromedio();
            c.alumnosDesaprobados();
        }
    }
}

