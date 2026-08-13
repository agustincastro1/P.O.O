using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_1
{
    /*
    Un restaurante automatizado procesa la comanda de una mesa para controlar la
preparación y el cobro de los platos pedidos.
 Crear la clase Plato que contenga como atributos privados: nombrePlato
(string) y precio (double). Definir sus propiedades correspondientes y un
constructor que reciba nom y pre.
 Crear la clase GestionComandas que administre una lista de objetos List.
 Métodos en GestionComandas:
o AgregarPlato():Solicitar por teclado los datos de un plato y
agregarlo a la lista utilizando .Add().
o MostrarComanda(): Listar todos los platos agregados hasta el
momento junto a la cantidad total de ítems pedidos utilizando la
propiedad .Count.
o CalcularTotalMesa(): Calcular y mostrar en pantalla el monto
total a cobrar sumando los precios de la lista.
o CancelarPlato(): Solicitar al usuario el nombre de un plato y, si
se encuentra en la lista, removerlo mediante .Remove() para
actualizar la comanda. 
    */
    class Plato
    {
        private string nombrePlato;
        private double precio;

        public string NombrePlato
        {
            set
            {
                nombrePlato = value;
            }
            get
            {
                return nombrePlato;
            }
        }
        public double Precio
        {
            set
            {
                precio = value;
            }
            get
            {
                return precio;
            }
        }

        public Plato(string nom, double pre)
        {

        }
    }
    class GestionComandas
    {

        static void Main(string[] args)
        {

        }
    }
}
