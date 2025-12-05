using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Enfermero
    {
        private ConexionDatos conexion = new ConexionDatos();

  
        public void RegistrarEnfermero(
            string nombre, string cedula, string telefono, string email,
            string turno, string area)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
             
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idPersonaGenerado = 0;

                    // INSERTAR EN PERSONAS Rol = 'Enfermero'
                    string queryPersona = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) " +
                                          "VALUES (@Nombre, @Cedula, @Telefono, @Email, 'Enfermero'); " +
                                          "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nombre", nombre);
                    cmdPersona.Parameters.AddWithValue("@Cedula", cedula);
                    cmdPersona.Parameters.AddWithValue("@Telefono", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                    idPersonaGenerado = (int)cmdPersona.ExecuteScalar();

                    // INSERTAR EN ENFERMERO
                    string queryEnfermero = "INSERT INTO Enfermero (IDPersona, Turno, Area) " +
                                            "VALUES (@IDPersona, @Turno, @Area)";

                    SqlCommand cmdEnfermero = new SqlCommand(queryEnfermero, conn, transaction);
                    cmdEnfermero.Parameters.AddWithValue("@IDPersona", idPersonaGenerado);
                    cmdEnfermero.Parameters.AddWithValue("@Turno", turno);
                    cmdEnfermero.Parameters.AddWithValue("@Area", area);

                    cmdEnfermero.ExecuteNonQuery();

                    // Confirmar cambios
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                        throw new Exception("Error: Ya existe alguien con esa Cédula.");
                    else
                        throw new Exception("Error SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar enfermero: " + ex.Message);
                }
            }
        }
    }
}