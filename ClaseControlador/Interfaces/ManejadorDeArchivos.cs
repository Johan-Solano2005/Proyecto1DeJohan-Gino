using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseControlador.Interfaces
{
    public interface ManejadorDeArchivos
    {
        string LoadFile(string filePath);
        List<IClientes> GetArchivos();

        bool SaveFile(string path);
    }
}
