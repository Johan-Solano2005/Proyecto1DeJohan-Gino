using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeModelo.Interfaces
{
    /// <summary>
    /// interfaz para cargar clientes
    /// </summary>
    public interface IClientes
    {
        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }

        
        public string Apellido { get; set; }

      
        public string Cedula { get; set; }

        public string NumeroDeTelefono { get; set; }
    }
}
