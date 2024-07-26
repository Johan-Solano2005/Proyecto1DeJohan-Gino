using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeModelo.Interfaces
{
    internal class Iinventario
    {
            public interface IInventario
            {
                /// <summary>
                /// Gets or sets the name of the item.
                /// </summary>
                string ItemName { get; set; }

                /// <summary>
                /// Gets or sets the quantity of the item in inventory.
                /// </summary>
                int Quantity { get; set; }

                /// <summary>
                /// Gets or sets the price of the item.
                /// </summary>
                decimal Price { get; set; }

                /// <summary>
                /// Converts the item details to a string.
                /// </summary>
                /// <returns>A string representation of the item.</returns>
                string ToString();
            }
            internal class Inventario
            {
                // Esta clase se utiliza para gestionar una coleccion de productos
            }

            public class Producto : IInventario
            {
                /// <summary>
                /// Initializes a new instance of the <see cref="Producto"/> class.
                /// </summary>
                public Producto()
                {
                }

                /// <summary>
                /// Initializes a new instance of the <see cref="Producto"/> class.
                /// </summary>
                /// <param name="NombreProducto">The name of the item.</param>
                /// <param name="CantidadProducto">The quantity of the item in inventory.</param>
                /// <param name="PrecioProducto">The price of the item.</param>
                public Producto(string NombreProducto, int CantidadProducto, decimal PrecioProducto)
                {
                    this.ItemName = NombreProducto;
                    this.Quantity = CantidadProducto;
                    this.Price = PrecioProducto;
                }

                /// <summary>
                /// Gets or sets the name of the item.
                /// </summary>
                public string ItemName { get; set; }

                /// <summary>
                /// Gets or sets the quantity of the item in inventory.
                /// </summary>
                public int Quantity { get; set; }

                /// <summary>
                /// Gets or sets the price of the item.
                /// </summary>
                public decimal Price { get; set; }

                /// <summary>
                /// Converts to string.
                /// </summary>
                /// <returns>A <see cref="System.String" /> that represents this instance.</returns>
                public override string ToString()
                {
                    return $"Item: {this.ItemName}, Quantity: {this.Quantity}, Price: {this.Price:C}";
                }
            }
        }
    }


