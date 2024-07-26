using ClaseDeModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeModelo
{
    internal class Inventario:Iinventario
    {
    }
    namespace ClaseDeModelo.Interfaces
    {
        internal class Inventario
        {
            /// <summary>
            /// Represents the concrete model of an inventory item.
            /// </summary>
            public class Producto
            {
                /// <summary>
                /// Initializes a new instance of the <see cref="Item"/> class.
                /// </summary>
                public Producto()
                {
                }

                /// <summary>
                /// Initializes a new instance of the <see cref="Item"/> class.
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
                /// <value>
                /// The name of the item.
                /// </value>
                public string ItemName { get; set; }

                /// <summary>
                /// Gets or sets the quantity of the item in inventory.
                /// </summary>
                /// <value>
                /// The quantity of the item.
                /// </value>
                public int Quantity { get; set; }

                /// <summary>
                /// Gets or sets the price of the item.
                /// </summary>
                /// <value>
                /// The price of the item.
                /// </value>
                public decimal Price { get; set; }

                /// <summary>
                /// Converts to string.
                /// </summary>
                /// <returns>
                /// A <see cref="System.String" /> that represents this instance.
                /// </returns>
                public override string ToString()
                {
                    return $"Item: {this.ItemName}, Quantity: {this.Quantity}, Price: {this.Price:C}";
                }
            }
        }
    }

}
       
     
    

