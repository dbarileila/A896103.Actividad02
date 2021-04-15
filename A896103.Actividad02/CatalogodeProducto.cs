using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A896103.Actividad02
{
    public class CatalogodeProducto
    {
        

        List<Producto> Productos = new List<Producto>();
       
        public List<Producto> ListadoProductos ()
        {
            return Productos;
        }
    

        public int IngresoNroDeProductos()
        {
            
            Console.WriteLine("Ingreso de nuevo producto.");
            Console.Write("Ingrese el número de producto: ");
            int nro;
            
            string ingreso;
            do
            {
                Console.WriteLine("Ingrese un número de producto válido, recuerde que debe ser mayor a cero: ");
                ingreso = Console.ReadLine();
               

            } while ((!int.TryParse(ingreso, out nro) && nro <= 0));

            return nro;
        }

        public int  IngresoStock()
        {

            int stock;
            Console.Write("Ingrese el stock inicial: ");
            string ingreso;
            do
            {
                Console.WriteLine("Ingrese el stock, recuerde que debe ser mayor a cero: ");
                ingreso = Console.ReadLine();
                
              
            } while ((!int.TryParse(ingreso, out stock) && stock <= 0));

            return stock;
        }

        public void AgregarProducto()
        {
            int nro = IngresoNroDeProductos();

            int stock = IngresoStock();

            Productos.Add(new Producto(nro, stock));

        }

      
       

       

    }

}
