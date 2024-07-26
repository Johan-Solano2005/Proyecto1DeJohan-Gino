using ClaseDeModelo.Interfaces;

namespace ClaseDeModelo
{
    public class Clientes:IClientes
    {
        public Clientes()
        {
        }

        /// <summary>
        /// Inicia una nueva instancia para un nuevo cliente
        /// </summary>
        /// <param name="cedula">El nombre de cedula .</param>
        /// <param name="nombre">El nombre.</param>
        /// <param name="apellido">El apellido .</param>
        /// <param name="numeroDeTelefono">El numero de telefono.</param>
        public Clientes(int cedula, string nombre, string apellido, int numeroDeTelefono)
        {
            this.Cedula = cedula.ToString();
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.NumeroDeTelefono = numeroDeTelefono.ToString();
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Nombre { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string Apellido { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>
        /// The country.
        /// </value>
        public string Cedula { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        /// 
        public string NumeroDeTelefono { get; set; }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return this.Cedula + " " + this.Nombre + " " + this.Apellido + " " + this.NumeroDeTelefono + " ";
        }
    }
}
