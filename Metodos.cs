using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examu1u2
{
    public class Metodos
    {
        static Inventario[] matrizInventario = new Inventario[10];


        static void InsertarProducto(int posicion, Inventario inventario)
        {
            matrizInventario[posicion] = inventario;


        }




        static void MatrizVacia()
        {
            if (MatrizVacia())
            {
                Console.WriteLine("La matriz esta vacia");
            }
            else
            {
                ImprimirMatriz();
            }
        }
        //Para ver si la matriz esta vacia
        static void MatrizVacia()
        {
            matrizInventario= null;
        }



        //Busqueda de un producto por precio
        static void BusquedaporProducto()
        {

        }
    }
}
