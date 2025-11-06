using System;
using CapaDatos;

namespace PruebaConexionBD
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Instanciamos la clase de conexión
                ConexionDatos conexion = new ConexionDatos();

                // Intentamos abrir la conexión
                var con = conexion.AbrirConexion();

                if (con != null && con.State == System.Data.ConnectionState.Open)
                {
                    Console.WriteLine("✅ Conexión exitosa a la base de datos.");
                }
                else
                {
                    Console.WriteLine("❌ No se pudo establecer la conexión.");
                }

                // Cerramos la conexión
                conexion.CerrarConexion();
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Error al conectar: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
