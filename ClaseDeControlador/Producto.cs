using ClaseDeControlador.ClaseDeModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeControlador
{
    namespace ClaseDeModelo.Interfaces
    {
        public interface IInventario
        {
            string ItemName { get; set; }
            int Quantity { get; set; }
            decimal Price { get; set; }
            string ToString();
        }

        public class Producto : IInventario
        {
            public string ItemName { get; set; }
            public int Quantity { get; set; }
            public decimal Price { get; set; }

            public Producto() { }

            public Producto(string nombreProducto, int cantidadProducto, decimal precioProducto)
            {
                ItemName = nombreProducto;
                Quantity = cantidadProducto;
                Price = precioProducto;
            }

            public override string ToString()
            {
                return $"Item: {ItemName}, Quantity: {Quantity}, Price: {Price:C}";
            }
        }
    }

    namespace ClaseDeModelo
    {
        public class Inventario
        {
            private List<Producto> productos = new List<Producto>();

            public void AgregarProducto(Producto producto)
            {
                productos.Add(producto);
            }

            public void EditarProducto(string nombre, int cantidad, decimal precio)
            {
                var producto = ObtenerProducto(nombre);
                if (producto != null)
                {
                    producto.Quantity = cantidad;
                    producto.Price = precio;
                }
            }

            public void EliminarProducto(string nombre)
            {
                var producto = ObtenerProducto(nombre);
                if (producto != null)
                {
                    productos.Remove(producto);
                }
            }

            public Producto ObtenerProducto(string nombre)
            {
                return productos.FirstOrDefault(p => p.ItemName == nombre);
            }

            public IEnumerable<Producto> ObtenerProductosBajosDeInventario(int umbral)
            {
                return productos.Where(p => p.Quantity < umbral);
            }
        }
    }
}