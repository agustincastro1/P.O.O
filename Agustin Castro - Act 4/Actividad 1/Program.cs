using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            //$500, realizar un programa que lea los sueldos que cobra cada empleado e
            //de $300.Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
            //informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más

            int empleados, x, sueldo, MenoresDe300, MayoresDe300;
            string linea;
            x = 1;
            MenoresDe300 = 0;
            MayoresDe300 = 0;
            Console.WriteLine("Ingrese la cantidad de empleados: ");
            linea = Console.ReadLine();
            empleados = int.Parse(linea);

            while (x <= empleados)
            {
                Console.WriteLine("Ingrese un sueldo entre 100 y 500: ");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                if(sueldo >= 100 && sueldo <= 300)
                {
                    MenoresDe300 = MenoresDe300 + 1;
                }
                else
                {
                    MayoresDe300 = MayoresDe300 + 1;
                }
                x++;
            }
            Console.WriteLine("La cantidad de sueldos entre 100 y 300 es: " +  MenoresDe300);
            Console.WriteLine("La cantidad de sueldos mayores a 300 es: " + MayoresDe300);
            Console.ReadKey();
        }
    }
}
