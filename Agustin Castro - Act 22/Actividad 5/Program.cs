using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_5
{
    class carrera
    {
        private int codigo;
        private DateTime horaInicio;
        private DateTime horaFin;
        private List<corredor> corredores;

        public int Codigo
        {
            set { this.codigo = value; }
            get { return codigo; }
        }

        public List<corredor> Corredores
        {
            set { this.corredores = value; }
            get { return corredores; }
        }

        public carrera()
        {
            string linea;
            Console.WriteLine("Ingrese el código de la carrera: ");
            linea = Console.ReadLine();
            this.codigo = int.Parse(linea);

            Console.WriteLine("ingrese la hora de inicio de la carrera (yyyy-MM-ddTHH:mm:ss): ");
            linea = Console.ReadLine();
            this.horaInicio = DateTime.Parse(linea);

            Console.WriteLine("ingrese la hora de fin de la carrera (yyyy-MM-ddTHH:mm:ss): ");
            linea = Console.ReadLine();
            this.horaFin = DateTime.Parse(linea);

            this.corredores = new List<corredor>();
        }

        public carrera(int codigo, DateTime horaInicio, DateTime horaFin)
        {
            this.codigo = codigo;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.corredores = new List<corredor>();
        }

        public TimeSpan calcularDuracion()
        {
            TimeSpan duracion = horaFin - horaInicio;
            return duracion;
        }

        public void agregarCorredor(corredor c)
        {
            this.corredores.Add(c);
        }
    }

    class corredor
    {
        private string nombre;
        private int dorsal;
        private TimeSpan tiempoTotal;

        public string Nombre
        {
            set { this.nombre = value; }
            get { return nombre; }
        }

        public int Dorsal
        {
            set { this.dorsal = value; }
            get { return dorsal; }
        }

        public TimeSpan TiempoTotal
        {
            set { this.tiempoTotal = value; }
            get { return tiempoTotal; }
        }

        public corredor(string nombre, int dorsal)
        {
            this.nombre = nombre;
            this.dorsal = dorsal;
        }

        public void TiempoCarrera(int minutos)
        {
            this.tiempoTotal = TimeSpan.FromMinutes(minutos);
        }

        public void TiempoCarrera(int horas, int minutos)
        {
            this.tiempoTotal = new TimeSpan(horas, minutos, 0);
        }
    }

    class Consola
    {
        static void Main(string[] args)
        {
            carrera[] Carreras = new carrera[4];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"DATOS DE LA CARRERA {i + 1}:");
                Carreras[i] = new carrera();

                TimeSpan duracionDeEstaCarrera = Carreras[i].calcularDuracion();

                Console.WriteLine("¿Cuántos corredores desea registrar en esta carrera?: ");
                int cantidadCorredores = int.Parse(Console.ReadLine());

                for (int j = 0; j < cantidadCorredores; j++)
                {
                    Console.WriteLine($"Datos del Corredor {j + 1}:");
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Número de Dorsal: ");
                    int dorsal = int.Parse(Console.ReadLine());

                    corredor nuevoCorredor = new corredor(nombre, dorsal);

                    if (duracionDeEstaCarrera.TotalHours < 1)
                    {
                        Console.WriteLine("(La carrera dura menos de una hora)");
                        Console.Write("Ingrese los minutos que duró el corredor: ");
                        int min = int.Parse(Console.ReadLine());
                        nuevoCorredor.TiempoCarrera(min);
                    }
                    else
                    {
                        Console.WriteLine("(La carrera dura una hora o más)");
                        Console.Write("Ingrese las horas que duró el corredor: ");
                        int hs = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese los minutos que duró el corredor: ");
                        int min = int.Parse(Console.ReadLine());
                        nuevoCorredor.TiempoCarrera(hs, min);
                    }

                    Carreras[i].agregarCorredor(nuevoCorredor);
                }
            }

            Carreras[2] = new carrera(3, new DateTime(2026, 05, 10, 08, 00, 00), new DateTime(2026, 05, 10, 09, 45, 00));
            Carreras[3] = new carrera(4, new DateTime(2026, 08, 15, 14, 30, 00), new DateTime(2026, 08, 15, 15, 15, 00));

            corredor corredorFijo1 = new corredor("Marcos", 99);
            corredorFijo1.TiempoCarrera(1, 20); 
            Carreras[2].agregarCorredor(corredorFijo1);

            corredor corredorFijo2 = new corredor("Lucía", 77);
            corredorFijo2.TiempoCarrera(40); 
            Carreras[3].agregarCorredor(corredorFijo2);


            TimeSpan duracionMayor = Carreras[0].calcularDuracion();
            carrera mayorDuracion = Carreras[0];

            for (int i = 1; i < Carreras.Length; i++)
            {
                if (Carreras[i].calcularDuracion() > duracionMayor)
                {
                    duracionMayor = Carreras[i].calcularDuracion();
                    mayorDuracion = Carreras[i];
                }
            }

            int auxCarrera = 0;
            int auxCorredor = 0;
            TimeSpan menorTiempo = TimeSpan.MaxValue;

            for (int i = 0; i < Carreras.Length; i++)
            {
                for (int j = 0; j < Carreras[i].Corredores.Count; j++)
                {
                    if (Carreras[i].Corredores[j].TiempoTotal < menorTiempo)
                    {
                        menorTiempo = Carreras[i].Corredores[j].TiempoTotal;
                        auxCarrera = i;
                        auxCorredor = j;
                    }
                }
            }

            Console.Clear();

            Console.SetCursorPosition(25, 25);
            Console.Write($"La carrera con mayor duración es la de Código: {mayorDuracion.Codigo} con una duración de {duracionMayor}");

            Console.SetCursorPosition(25, 40);

                Console.WriteLine("El corredor más rápido es " + Carreras[auxCarrera].Corredores[auxCorredor].Nombre + " (Dorsal: " + Carreras[auxCarrera].Corredores[auxCorredor].Dorsal + ") con un tiempo de " + Carreras[auxCarrera].Corredores[auxCorredor].TiempoTotal);


            Console.SetCursorPosition(25, 45);
            Console.ReadKey();
        }
    }
}
