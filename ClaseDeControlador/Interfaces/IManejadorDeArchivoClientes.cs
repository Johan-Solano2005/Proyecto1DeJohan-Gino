using ClaseDeModelo;
using ClaseDeModelo.Interfaces;
using System;



namespace ClaseDeControlador.Interfaces
{
    /// <summary>
    /// interfaz para manejar archivo de clientes
    /// </summary>
    public interface IManejadorDeArchivoClientes
    {
        public string CargarArchivo(string filePath)
        {
            var contenido = File.ReadAllText(filePath);
            return contenido;
        }

        /// <summary>
        /// cargar clientes
        /// </summary>
        /// <param name="path">The filePath.</param>
        /// <returns>A list of People from the file.</returns>
        public List<IClientes> CargarClientes(string path)
        {
            var resultado = new List<IClientes>();
            var content = this.CargarArchivo(path);
            var lines = content.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                var partes = line.Split(',');
                var cliente = new Clientes();
                cliente.Cedula = partes[0];
                cliente.Nombre = partes[1];
                cliente.Apellido = partes[2];
                cliente.NumeroDeTelefono = partes[3];
                resultado.Add(cliente);
            }

            return resultado;
        }
        
        /// <summary>
        /// Ssalvar el archivo de clientes
        /// </summary>
        /// <param name="path">The filePath.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool GuardarArchivo(string path)
        {
            throw new NotImplementedException();
        }
    }
}
