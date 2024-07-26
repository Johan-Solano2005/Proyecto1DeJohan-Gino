using ClaseDeModelo.Interfaces;



namespace ClaseDeControlador.Interfaces
{
    /// <summary>
    /// Interface for file handle
    /// </summary>
    public interface IManejadorDeArchivoClientes
    {
        /// <summary>
        /// cagar archivo de clientes
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        string CargarArchivo(string path);
        /// <summary>
        ///  cargar clientes
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>

        List<IClientes> CargarClientes(string path);

        /// <summary>
        /// guardar archivo
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>


        bool GuardarArchivo(string path);
    }
}
