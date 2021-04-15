using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A896103.Actividad02
{
    class Program
    {

        static void Main(string[] args)
        {
            /*Una empresa de productos farmacéuticos necesita un sistema de control de stock. Para ello se
            le solicita una aplicación que permita:
              A) El ingreso de un catálogo de productos (identificado por número de producto), junto
              con el stock inicial para cada uno.
              B) El ingreso de una cantidad de pedidos y entregas de productos. Los pedidos restan al
              stock del producto y las entregas suman. El sistema debe ir controlando que las
              cantidades no sean menores a 0 en ningún momento.
              C) Al terminar, reporte el stock final de cada producto.  
           */
            CatalogodeProducto CatalogoProductos = new CatalogodeProducto();

            string salida;
            do
            {
                CatalogoProductos.AgregarProducto();
                
                Console.WriteLine("¿Desea continuar? SI/NO: ");
                salida = Console.ReadLine();

            } while (salida == "SI");

            string salida2;
            do
            {
                Console.WriteLine("¿Qué quiere ingresar? PEDIR/ENTREGAR");
                string tipo = Console.ReadLine();
                Console.WriteLine($"¿Qué producto quiere {tipo}?: ");
                int nro = Convert.ToInt32(Console.ReadLine());
           
                //Producto prod = CatalogoProductos.ListadoProductos()
                //        .FirstOrDefault(producto => producto.NumerodeProducto == nro);

                foreach(Producto producto in CatalogoProductos.ListadoProductos())
                {
                    Console.WriteLine($"Número: {producto.NumerodeProducto}");
                }

  
                    if (tipo == "PEDIR")
                    {

                      CatalogoProductos.ListadoProductos()
                     .FirstOrDefault(producto => producto.NumerodeProducto == nro).RestarStock();

                    }

                    if (tipo == "ENTREGAR")
                    {

                       CatalogoProductos.ListadoProductos()
                       .FirstOrDefault(producto => producto.NumerodeProducto == nro).SumarStock();

                    }

                

                Console.WriteLine("¿Desea continuar? SI/NO: ");
                salida2 = Console.ReadLine();

            } while (salida2 == "SI");

            Console.WriteLine("Reporte de Stock: ");
            foreach (Producto Producto in CatalogoProductos.ListadoProductos())
            {
                Console.WriteLine($"Producto: {Producto.NumerodeProducto} - Stock: {Producto.Stock} ");
            }

            Console.ReadKey();
        }

       
        
        

    }
}
