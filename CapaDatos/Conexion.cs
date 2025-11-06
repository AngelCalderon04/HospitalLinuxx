using System;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class ConexionDatos
    {
        //Declaracion de la conexion a Sql
        private SqlConnection Conexion;

        //Constructor de la clase ConexionDatos

        public ConexionDatos()

        {
            Conexion = new SqlConnection("Server= . ; Database=HospitalLinux; Integrated security=true; TrustServerCertificate=True");

        }
        //Metodo para abrir la conexion a la base de datos 

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == System.Data.ConnectionState.Closed)
            {
                // abre la conexion si esta cerrada
                Conexion.Open();
            }
            return Conexion;

        }

        // Método para cerrar la conexion a la base de Datos 
        public void CerrarConexion()
        {
            //  Aqui verifica si la conexion esta abierta antes de cerrarla
            if (Conexion.State == System.Data.ConnectionState.Open)
            {
                //Cierra la conexion si esta abierta
                Conexion.Close();
            }
        }
    }



}