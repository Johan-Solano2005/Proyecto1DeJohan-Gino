using ClaseDeControlador.ClaseDeModelo.Interfaces;
using ClaseDeControlador.ClaseDeModelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeControlador
{
    internal class ControladorProducto
    {
            private Inventario inventario;

            public ControladorProducto(Inventario inventario)
            {
                this.inventario = inventario;
            }

            public void AgregarProducto(string nombre, int cantidad, decimal precio)
            {
                var producto = new Producto(nombre, cantidad, precio);
                inventario.AgregarProducto(producto);
            }

            public void EditarProducto(string nombre, int cantidad, decimal precio)
            {
                inventario.EditarProducto(nombre, cantidad, precio);
            }

            public void EliminarProducto(string nombre)
            {
                inventario.EliminarProducto(nombre);
            }

            public Producto ObtenerProducto(string nombre)
            {
                return inventario.ObtenerProducto(nombre);
            }

            public IEnumerable<Producto> ObtenerProductosBajosDeInventario(int umbral)
            {
                return inventario.ObtenerProductosBajosDeInventario(umbral);
            }
        }
    }

