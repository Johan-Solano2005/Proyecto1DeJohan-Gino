using ClaseDeModelo.Interfaces;



namespace ClaseDeControlador.Interfaces
{
    /// <summary>
    /// Interface for file handle
    /// </summary>
    public interface IManejadorDeArchivos
    {
        string LoadFile(string path);

        List<IClientes> LoadPeople(string path);

        bool SaveFile(string path);
    }
}
