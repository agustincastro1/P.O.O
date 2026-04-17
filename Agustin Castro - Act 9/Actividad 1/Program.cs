using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*1. Se desea desarrollar un programa que permita registrar los nombres y las
         calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
         nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
         estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
         máxima o mínima.*/
    class Vectores1
    {
        private string[] alumnos;
        private string[] alumnosNotaAlta;
        private string[] alumnosNotaBaja;
        private int[] notaAlum;
        private int notaAlta;
        private int notaBaja;
        private int Altas = 0;
        private int Bajas = 0;
        public void cargar()
        {
            alumnos = new string[6];
            notaAlum = new int[6];
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.WriteLine("ingrese el nombre de un alumno");
                string linea;
                linea = Console.ReadLine();
                alumnos[i] = linea;

                Console.WriteLine("ingrese la nota del alumno");
                linea = Console.ReadLine();
                notaAlum[i] = int.Parse(linea);
            }
        }
        
        public void calcularNotas()
        {
        
            for (int i = 0; i < notaAlum.Length; i++)
            {
                for (int j = 0; j < notaAlum.Length - i - 1; j++)
                {
                    if (i != 5)
                    {
                        if (notaAlum[j] > notaAlum[j + 1])
                        {
                            int aux;
                            string auxAlum;
                            aux = notaAlum[j];
                            auxAlum = alumnos[j];
                            notaAlum[j] = notaAlum[j + 1];
                            alumnos[j] = alumnos[j + 1];
                            notaAlum[j + 1] = aux;
                            alumnos[j + 1] = auxAlum;
                        }
                    }
                }
                notaAlta = notaAlum[5];
                notaBaja = notaAlum[0];
                
            }
            for (int i = 0;i < notaAlum.Length; i++)
            {
                if (notaAlum[i] == notaAlta)
                {
                    Altas++;
                }
                if (notaAlum[i] == notaBaja)
                {
                    Bajas++;
                }
            }
            alumnosNotaAlta = new string[Altas];
            alumnosNotaBaja = new string[Bajas];
            int u = 0, x = 0;

            for (int i = 0; i < alumnos.Length; i++)
            {
                if (notaAlum[i] == notaAlta)
                {
                    alumnosNotaAlta[u] = alumnos[i];
                    u++;
                }
                if (notaAlum[i] == notaBaja)
                {
                    alumnosNotaBaja[x] = alumnos[i];
                    x++;
                }
            }
        }

        public void mostrar()
        {
            for (int i = 0; i < alumnosNotaAlta.Length; i++)
            {
                Console.WriteLine("Alumnos con la nota mas alta: " + alumnosNotaAlta[i] + " Nota: " + notaAlta);
            }
            for (int i = 0; i < alumnosNotaAlta.Length; i++)
            {
                Console.WriteLine("Alumnos con la nota mas abaja: " + alumnosNotaBaja[i] + " Nota: " + notaBaja);
            }
            Console.WriteLine("------------------------");
            if (Altas > 1 || Bajas > 1) 
            {
                Console.WriteLine("la cantidad de alumnos con la nota mas alta es: " + Altas);
                Console.WriteLine("la cantidad de alumnos con la nota mas baja es: " + Bajas);
            }
        }
        static void Main(string[] args)
        {
            Vectores1 v1 = new Vectores1();
            v1.cargar();
            v1.calcularNotas();
            v1.mostrar();
            Console.ReadKey();
        }
    }
}
