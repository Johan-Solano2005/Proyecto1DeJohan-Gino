using ClaseDeModelo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseDeControlador
{
    internal class ControladorDeClientes
    {

        private string NombreDeArchivo { get; set; } = "Clietes.csv";
        private int ContadorDeClientes { get; set; } = 30;
        private  ControladorDeArchivosClientes ControladorDeArchivosClientes { get; set; } = new ControladorDeArchivosClientes();

        /// <summary>
        /// Gets the users.
        /// </summary>
        /// <returns>The list of the system's users.</returns>
        public List<IClientes> ObtenerClientes()
        {
            var filePath = this.ConseguirArchivo();
            var resultado = this.ControladorDeArchivosClientes.CargarClientes(filePath);
            return resultado;
        }

        private string ConseguirArchivo()
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), this.NombreDeArchivo);
            if (!File.Exists(filePath))
            {
                this.GenerarClientes(filePath, this.ContadorDeClientes);
            }

            return filePath;
        }

        private void GenerarClientes(string filePath, int datos)
        {
            var cedula = new string[] {"119480421", "11820965" , "119270903" ,"783456789", "846897567", "542345678", "123423457", "195456789", "119270903" };
            var nombres = new string[] { "Johan", "Gino", "Kevin", "Josue", "John", "Ariana", "Jose", "Bryan", "Jonathan" };
            var apellidos = new string[] { "Solano", "Moreira", "Chacon", "Castro", "Torres", "Mauricio", "Castillo", "Guerrero", "Hernandez" };
            var numeroDeTelefono = new string[] { "12895678", "67438927", "19283709", "98734598", "1029384704", "10293847", "56890389", "45642987", "18928748" };

            var random = new Random();

            using (var sw = new StreamWriter(filePath, false, Encoding.UTF8))
            {
                sw.WriteLine("Cedula,Nombre,Apellido,NumeroDeCelularr");
                var NumeroDeFilas = 0;

                for (int i = 0, j = 0, k = 0, u = 0; NumeroDeFilas < datos; k++, i++, j++, u++)
                {
                    if (cedula.Length-1 == i ||nombres.Length - 1 == j || apellidos.Length - 1 == k || numeroDeTelefono.Length - 1 == u)
                    {
                        i = 0;
                        j = 0;
                        k = 0;
                        u = 0;
                    }
                    var cedulaRnad = random.Next(0, cedula.Length);
                    var nombreRand = random.Next(0, nombres.Length);
                    var apellidosRand = random.Next(0, apellidos.Length);
                    var numerosDeTelefonoRand = random.Next(0, numeroDeTelefono.Length);

                    sw.WriteLine($"{cedula[cedulaRnad]},{nombres[nombreRand]},{apellidos[apellidosRand]},{numeroDeTelefono[numerosDeTelefonoRand]}");
                    NumeroDeFilas++;
                }
            }
        }
    }
}


