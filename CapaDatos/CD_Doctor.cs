using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Doctor
    {
        private ConexionDatos conexion = new ConexionDatos();

        // Recibimos los datos sueltos para guardar
        public void RegistrarDoctor(
            string nombre, string cedula, string telefono, string email,
            string especialidad, string exequatur, decimal tarifa)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    int idPersonaGenerado = 0;

                    //  INSERTAR PERSONA Rol = 'Doctor'
                    string queryPersona = "INSERT INTO Personas (Nombre, Cedula, Telefono, Email, Rol) " +
                                          "VALUES (@Nombre, @Cedula, @Telefono, @Email, 'Doctor'); " +
                                          "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                    SqlCommand cmdPersona = new SqlCommand(queryPersona, conn, transaction);
                    cmdPersona.Parameters.AddWithValue("@Nombre", nombre);
                    cmdPersona.Parameters.AddWithValue("@Cedula", cedula);
                    cmdPersona.Parameters.AddWithValue("@Telefono", telefono);
                    cmdPersona.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);

                    idPersonaGenerado = (int)cmdPersona.ExecuteScalar();

                    // INSERTAR DOCTOR
                    string queryDoctor = "INSERT INTO Doctor (IDPersona, Especialidad, Exequatur, TarifaConsulta) " +
                                         "VALUES (@IDPersona, @Especialidad, @Exequatur, @Tarifa)";

                    SqlCommand cmdDoctor = new SqlCommand(queryDoctor, conn, transaction);
                    cmdDoctor.Parameters.AddWithValue("@IDPersona", idPersonaGenerado);
                    cmdDoctor.Parameters.AddWithValue("@Especialidad", especialidad);
                    cmdDoctor.Parameters.AddWithValue("@Exequatur", exequatur);
                    cmdDoctor.Parameters.AddWithValue("@Tarifa", tarifa);

                    cmdDoctor.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (SqlException sqlEx)
                {
                    transaction.Rollback();
                    if (sqlEx.Number == 2627 || sqlEx.Number == 2601)
                        throw new Exception("Error: Ya existe un médico con esa Cédula.");
                    else
                        throw new Exception("Error SQL: " + sqlEx.Message);
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw new Exception("Error al guardar doctor: " + ex.Message);
                }
            }
        }
    }
}