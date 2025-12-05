using System;
using System.Data;
using Microsoft.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Citas
    {
        private ConexionDatos conexion = new ConexionDatos();

        
        public void AgendarCita(int idPaciente, int idDoctor, DateTime fecha, TimeSpan hora, string motivo)
        {
            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                try
                {
                    // Query BD
                    string query = "INSERT INTO Citas (IDPaciente, IDDoctor, FechaCita, HoraCita, MotivoCita, Estado) " +
                                   "VALUES (@IDPaciente, @IDDoctor, @FechaCita, @HoraCita, @MotivoCita, 'Pendiente')";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IDPaciente", idPaciente);
                    cmd.Parameters.AddWithValue("@IDDoctor", idDoctor);
                    cmd.Parameters.AddWithValue("@FechaCita", fecha);
                    cmd.Parameters.AddWithValue("@HoraCita", hora);
                    cmd.Parameters.AddWithValue("@MotivoCita", motivo ?? (object)DBNull.Value);

                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al agendar la cita: " + ex.Message);
                }
            }
        }
    }
}