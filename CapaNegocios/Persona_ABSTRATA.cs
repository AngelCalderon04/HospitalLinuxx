using System;
using System.Runtime.ConstrainedExecution;
using Azure.Identity;
using CapaDatos;
using Microsoft.Data.SqlClient;

namespace Personas

{   //Clase padre BASE 
    public abstract class Persona

    {
        public int IDpersona { get; set; }
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Rol { get; set; }
        public DateTime FechaRegistro { get; set; }

        //instacia de conexion

        protected ConexionDatos Conexion;

        //TODO Construtor vacio para consultar en BD 
        public Persona()
        {

            Conexion = new ConexionDatos();
        }
        //construtor para crear nuevos registros 
        public Persona(string Nombre, string Cedula, string Telefono, string Email, string Rol)

        {
            Conexion = new ConexionDatos();

            this.Nombre = Nombre;
            this.Cedula = Cedula;
            this.Telefono = Telefono;
            this.Email = Email;
            this.Rol = Rol;

        }
        //Metodo abstrato, esta es una clase HIJA 
        public abstract string GenerarDiagnostico();

        //metodo virtual 
        public virtual decimal CalcularHonorarios()
        {
            return 0; // Por defecto, nadie cobra (solo Doctor y enferos cobraran)
        }

        public int Insertar()
        {
            int IDGenerado = 0;


            try
            {

                //Abrir conexion 
                SqlConnection conn = Conexion.AbrirConexion();

                // comando para insertar a sql 

                string sql = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol, FechaRegistro) " +
                             "VALUES (@Nombre, @Cedula, @Telefono, @Email, @Rol, GETDATE()); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                //Crear el comando
                SqlCommand cmd = new SqlCommand(sql, conn);

                // 4. Pasar los valores (esto evita SQL Injection)
                cmd.Parameters.AddWithValue("@Nombre", this.Nombre);
                cmd.Parameters.AddWithValue("@Cedula", this.Cedula);
                cmd.Parameters.AddWithValue("@Telefono", this.Telefono);
                cmd.Parameters.AddWithValue("@Email", this.Email);
                cmd.Parameters.AddWithValue("@Rol", this.Rol);

                //  Ejecutar y obtener el ID que generó la BD
                IDGenerado = (int)cmd.ExecuteScalar();

                // Guardar el ID en la propiedad
                this.IDpersona = IDGenerado;

            }

            catch (Exception ex)
            {
                // Si algo sale mal, mostrar el error
                throw new Exception("Error al guardar: " + ex.Message);
            }
            finally
            {
                // SIEMPRE cerrar la conexión
                Conexion.CerrarConexion();
            }

            return IDGenerado;

        }

    }
}