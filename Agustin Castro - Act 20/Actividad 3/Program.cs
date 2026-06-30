using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_3
{
    /*
Problema:
Un instituto de arqueología desea registrar las visitas semanales a 3 zonas
arqueológicas durante 4 semanas.
Plantear una matriz de 3x4 donde las filas representan las zonas y las columnas los
días. Luego:
 Calcular el total de visitas por zona y almacenarlo en un vector.
 Mostrar los datos en forma tabular.
 Agregar estos resultados a una lista llamada zonasVisitadas que contenga
nombres de zonas y total de visitas.
 Determinar cuál fue la zona más visitada.
     */
    class Instituto
    {
        private int[,] visitas;
        private int[] visitasPorZona;
        private int total = 0;
        public Instituto()
        {
            visitas = new int[3, 4];
            visitasPorZona = new int[3];

            for (int i = 0; i < visitas.GetLength(0); i++)
            {
                for (int j = 0; j < visitas.GetLength(1); j++)
                {
                    string linea;
                    Console.WriteLine($"Ingrese las visitas de la zona: {i + 1} en la semana {j + 1}:");
                    linea = Console.ReadLine();
                    visitas[i,j] = int.Parse(linea);

                    total = total + visitas[i, j];
                }
                visitasPorZona[i] = total;
                total = 0;
            }
        }
        public void mostrarVisitas()
        {
            Console.WriteLine("Lista de visitas:");
            for(int i = 0; i  < visitas.GetLength(0); i++)
            {
                for (int j = 0; j < visitas.GetLength(1); j++)
                {
                    Console.Write(visitas[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("=============");
        }
        public void listaDeVisitas()
        {
            int zonaVisitada = visitasPorZona[0];
            List<(string nombre, int visitasTotales)> listaVisitas = new List<(string nombre, int visitasTotales)>();
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Ingrese el nombre de la zona {i + 1}:");
                string nombreZona = Console.ReadLine();
                listaVisitas.Add((nombreZona, visitasPorZona[i]));
            }

            Console.WriteLine("Zonas visitadas:");
            foreach (var zV in listaVisitas)
            {
                Console.WriteLine($"{zV.nombre}: {zV.visitasTotales} visitas");
            }

            var zonaMasVisitada = listaVisitas[0];
            foreach (var zV in listaVisitas)
            {
                if (zV.visitasTotales > zonaMasVisitada.visitasTotales)
                {
                    zonaMasVisitada = zV;
                }
            }
            Console.WriteLine($"La zona más visitada fue: {zonaMasVisitada.nombre} con {zonaMasVisitada.visitasTotales} visitas");
        }

        static void Main(string[] args)
        {
            Instituto instituto = new Instituto();
            instituto.mostrarVisitas();
            instituto.listaDeVisitas();
            Console.ReadKey();
        }
    }
}
