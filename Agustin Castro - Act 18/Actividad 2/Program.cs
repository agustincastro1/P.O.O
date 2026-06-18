using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_2
{
    /*
    2.
Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
La clase CriaturaMarina debe tener como atributos privados: Especie (string),
ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
● La profundidad óptima sea estrictamente mayor a cero (0).
● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
nivel de salinidad para sobrevivir. 
    */
    class CriaturaMarina
    {
        private string Especie;
        private int ProfundidadOptima;
        private int NivelSalinidad;

        public string especie
        {
            set
            {
                Especie = value;
            }
            get
            {
                return Especie;
            }
        }
        public int profundidadOptima
        {
            set
            {
                ProfundidadOptima = value;
            }
            get
            {
                return ProfundidadOptima;
            }
        }
        public int nivelSalinidad
        {
            set
            {
                NivelSalinidad = value;
            }
            get
            {
                return NivelSalinidad;
            }
        }

        public CriaturaMarina()
        {
            string linea;
            Console.WriteLine("Ingrese la especie de la criatura: ");
            Especie = Console.ReadLine();

            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("Ingrese la profundidad optima que tiene la criatura: ");
                linea = Console.ReadLine();
                if (int.Parse(linea) > 0)
                {
                    ProfundidadOptima = int.Parse(linea);
                }
                else
                {
                    Console.WriteLine("La profundidad Optima tiene que se mayor a 0");
                    i--;
                }
            }

            Console.WriteLine("Ingrese el nivel de salinidad de la criatura (entre 1 - 100): ");
            linea = Console.ReadLine();
            if (int.Parse(linea) >= 1 && int.Parse(linea) <= 100)
            {
                NivelSalinidad = int.Parse(linea);
            }
            else
            {
                NivelSalinidad = 35;
            }
        }
    }
    class HabitatAcuatico
    {
        public CriaturaMarina[] Criaturas;
        public HabitatAcuatico()
        {
            Criaturas = new CriaturaMarina[3];
            for (int i = 0; i < 3; i++)
            {
                Criaturas[i] = new CriaturaMarina();
            }
        }
        public void OrdenarCriaturas()
        {
            for (int i = 0; i < Criaturas.Length; i++)
            {
                for (int j = 0; j < 3 - i - 1; j++)
                {
                    if (Criaturas[j].profundidadOptima < Criaturas[j + 1].profundidadOptima)
                    {
                        CriaturaMarina aux = Criaturas[j];
                        Criaturas[j] = Criaturas[j + 1];
                        Criaturas[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("Criaturas ordenadas por profundidad:");
            for (int i = 0;i < Criaturas.Length; i++)
            {
                Console.WriteLine(Criaturas[i].especie);
            }
        }
        public void MayorNivelSalinidad()
        {
            for (int i = 0; i < Criaturas.Length; i++)
            {
                for (int j = 0; j < 3 - i - 1; j++)
                {
                    if (Criaturas[j].nivelSalinidad < Criaturas[j + 1].nivelSalinidad)
                    {
                        CriaturaMarina aux = Criaturas[j];
                        Criaturas[j] = Criaturas[j + 1];
                        Criaturas[j + 1] = aux;
                    }
                }
            }
            Console.WriteLine("la criatura que necesita mayor nivel de salinidad para sobrevivir es: " + Criaturas[2].especie);
        }
        static void Main(string[] args)
        {
            HabitatAcuatico HA = new HabitatAcuatico();
            HA.OrdenarCriaturas();
            HA.MayorNivelSalinidad();
            Console.ReadKey();
        }
    }
}
