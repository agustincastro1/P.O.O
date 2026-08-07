using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
    1-
En un servidor de red, las solicitudes de impresión se procesan dinámicamente en orden de
llegada.
 Crear la clase Documento que contenga como atributos privados:
nombreArchivo (string) y cantidadPaginas (int). Definir sus
propiedades de solo lectura y un constructor que reciba los parámetros nom
y pag.
 Crear la clase ServidorImpresion que administre una lista dinámica de
documentos (List<Documento>).
 Métodos en ServidorImpresion:
1. AgregarDocumento(): Solicitar por teclado los datos de un
documento y agregarlo al final de la lista utilizando .Add().
2. ImprimirSiguiente(): Si la lista no está vacía, simular la
impresión del primer documento de la lista (mostrar sus datos en
consola) y removerlo de la colección mediante .RemoveAt(0). Si está
vacía, advertir que no hay trabajos pendientes.
3. MostrarColaPendiente(): Listar todos los documentos que
están esperando ser impresos y la cantidad total de páginas
acumuladas en la cola de espera utilizando .Count. 
    */
    class Documento
    {
        private string nombreArchivo;
        private int cantidadPaginas;

        public string NombreArchivo
        {
            set
            {
                nombreArchivo = value;
            }
            get
            {
                return nombreArchivo;
            }
        }
        public int CantidadPaginas
        {
            set
            {
                cantidadPaginas = value;
            }
            get
            {
                return cantidadPaginas;
            }
        }
        public Documento(string nom, int pag)
        {
            NombreArchivo = nom;
            CantidadPaginas = pag;
        }
    }
    class ServidorImpresion
    {
        List<Documento> documentos = new List<Documento>();

        public void AgregarDocumento()
        {
            int pag;
            string linea, nom;
            Console.WriteLine("Ingrese los datos del documento");
            Console.WriteLine("Nombre:");
            nom = Console.ReadLine();
            Console.WriteLine("Cantidad de paginas:");
            linea = Console.ReadLine();
            pag = int.Parse(linea);
            Documento documento = new Documento(nom, pag);
            documentos.Add(documento);
        }

        public void ImprimirSiguiente()
        {
            if (documentos.Count > 0)
            {
                Console.WriteLine("Archivo impreso:");
                Console.WriteLine($"nombre del archivo:{documentos[0].NombreArchivo}");
                Console.WriteLine($"cantidad de paginas:{documentos[0].CantidadPaginas}");
                Console.WriteLine("------------------------------------------------");
                documentos.RemoveAt(0);
            }
            else
            {
                Console.WriteLine("no hay trabajos pendientes");
            }
        }
        public void MostrarColaPendiente()
        {
            if (documentos.Count > 0)
            {
            Console.WriteLine($"Lista de documentos pendientes ({documentos.Count}):");
                foreach (Documento documento in documentos)
                {
                    Console.WriteLine($"Nombre del documento: {documento.NombreArchivo}");
                    Console.WriteLine($"Cantidad de paginas del documento: {documento.CantidadPaginas}");
                    Console.WriteLine("------------------------------------------------");
                }
            }
            else
            {
                Console.WriteLine("no hay trabajos pendientes");
            }

        }
        static void Main(string[] args)
        {
            ServidorImpresion SV = new ServidorImpresion();
            while (true) {
                string linea;
                int eleccion;
                Console.WriteLine("Eliga una opcion escribiendo su numero:");
                Console.WriteLine("1. Agregar un nuevo documento | 2. Imprimir documento | 3. Mostrar lista de documentos pendientes | 4. Cerrar impresora");

                linea = Console.ReadLine();
                eleccion = int.Parse(linea);

                if (eleccion == 1)
                {
                    Console.Clear();
                    SV.AgregarDocumento();
                    Console.WriteLine("Documento agregado.");
                }
                if (eleccion == 2)
                {
                    Console.Clear();
                    SV.ImprimirSiguiente();
                }
                if (eleccion == 3)
                {
                    Console.Clear();
                    SV.MostrarColaPendiente();
                }
                if (eleccion == 4)
                {
                    Console.Clear();
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
