using ClaseDeControlador.ClaseDeModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeControlador
{
    internal class Vista { 
    }

    namespace ClaseDeModelo.Vista
    {
        public class Vista
        {
            public void MostrarMensaje(string mensaje)
            {
                Console.WriteLine(mensaje);
            }

            public Producto LeerProducto()
            {
                Console.Write("Ingrese el nombre del producto: ");
                string nombre = Console.ReadLine();
                Console.Write("Ingrese la cantidad del producto: ");
                int cantidad = int.Parse(Console.ReadLine());
                Console.Write("Ingrese el precio del producto: ");
                decimal precio = decimal.Parse(Console.ReadLine());

                return new Producto(nombre, cantidad, precio);
            }

            public void MostrarProducto(Producto producto)
            {
                if (producto != null)
                {
                    Console.WriteLine(producto.ToString());
                }
                else
                {
                    Console.WriteLine("Producto no encontrado.");
                }
            }

            public void MostrarProductosBajosDeInventario(IEnumerable<Producto> productos)
            {
                Console.WriteLine("Productos con bajo inventario:");
                foreach (var producto in productos)
                {
                    Console.WriteLine(producto.ToString());
                }
            }
        }
    }
}

        