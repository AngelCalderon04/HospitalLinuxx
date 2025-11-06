using System;
using Microsoft.Data.SqlClient;
using CapaDatos;

namespace Citas
{
    public class Citas
    {
        public int IDCita { get; set; }
        public int IDPaciente { get; set; }
        public int IDDoctor { get; set; }
        public DateTime FechaCita { get; set; }
        public TimeSpan HoraCita { get; set; }
        public string MotivoCita { get; set; }

        private ConexionDatos conexion;

        public Citas()
        {
            conexion = new ConexionDatos();
        }

        public Citas(int idPaciente, int idDoctor, DateTime fechaCita, TimeSpan horaCita, string motivoCita)
        {
            conexion = new ConexionDatos();
            IDPaciente = idPaciente;
            IDDoctor = idDoctor;
            FechaCita = fechaCita;
            HoraCita = horaCita;
            MotivoCita = motivoCita;
        }

        public int Insertar()
        {
            try
            {
                SqlConnection conn = conexion.AbrirConexion();

                string sql = "INSERT INTO Citas (IDPaciente, IDDoctor, FechaCita, HoraCita, MotivoCita) " +
                             "VALUES (@IDPaciente, @IDDoctor, @FechaCita, @HoraCita, @MotivoCita); " +
                             "SELECT CAST(SCOPE_IDENTITY() AS INT);";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IDPaciente", this.IDPaciente);
                cmd.Parameters.AddWithValue("@IDDoctor", this.IDDoctor);
                cmd.Parameters.AddWithValue("@FechaCita", this.FechaCita);
                cmd.Parameters.AddWithValue("@HoraCita", this.HoraCita);
                cmd.Parameters.AddWithValue("@MotivoCita", this.MotivoCita ?? (object)DBNull.Value);

                int idGenerado = (int)cmd.ExecuteScalar();
                this.IDCita = idGenerado;
                return idGenerado;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar cita: " + ex.Message);
            }
            finally
            {
                conexion.CerrarConexion();
            }
        }
    }
}
