using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Examu1u2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventario inventario = new Inventario();

            //Insercionproducto
            Console.WriteLine("Quiere insertar un nuevo producto? si/no");
            respuesta = Convert.ToString(Console.ReadLine());

            if (respuesta == si)
            {
                Console.WriteLine("Ingrese el nombre del producto");
                Nombre1 = Convert.ToString(Console.ReadLine());

                Console.WriteLine("Ingrese el precio del producto");
                Precio1 = Convert.ToInt32(Console.ReadLine());

            }
            else
            {
                ImprimirMatriz();
            }

            //Mostrarlalista
            Console.WriteLine("Quiere ver la lista de productos existentes? si/no");
            respuesta = Convert.ToString(Console.ReadLine());

            if (respuesta == si)
            {
                ImprimirMatriz();
            }

            else
            {
                ImprimirMatriz();
            }

            //Busquedaporprecio
            Console.WriteLine("Quiere buscar un producto? si/no");
            respuesta = Convert.ToString(Console.ReadLine());

            if (respuesta == si)
            {
                Console.WriteLine("Pon el precio del producto que quieres buscar");
                Precio2 = Convert.ToInt32(Console.ReadLine());

                BusquedaPorProducto();
            }

            else
            {
                ImprimirMatriz();
            }

        }
    }
}